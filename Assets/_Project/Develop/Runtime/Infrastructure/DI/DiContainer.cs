
using System;
using System.Collections.Generic;


namespace Assets._Project.Develop.Runtime.Infrastructure.DI
{
    public class DIContainer 
    {
      
        private readonly Dictionary<Type, Registration> _container = new();
        private readonly List<Type> _requests = new();

        private readonly DIContainer _parent;

        public DIContainer(): this (null) 
        { 
            
        
        
        }

        
        public DIContainer(DIContainer parent) => _parent = parent;


        public void RegisterAsSingle<T>(Func<DIContainer, T> creator)// каждая зависимость будет в единственном экземпляре;
        {

            if (IsAlreadyRegister<T>())
                throw new InvalidOperationException($"{typeof(T)} already register");



            Registration registration = new(container => creator.Invoke(container)); // создаем регистрацию;
            _container.Add(typeof(T), registration); // регистрируем в контейнере тип по которому будем запрашивать сервис;

        }

        public bool IsAlreadyRegister<T>()
        {
            if (_container.ContainsKey(typeof(T)))
                return true;

            if(_parent != null)
                return _parent.IsAlreadyRegister<T>();
           
            return false;

        }



        public T Resolve<T>()  // запрашиваем сервис по типу;
        {
            if (_requests.Contains(typeof(T)))
                throw new InvalidOperationException($"Circular dependency detected for {typeof(T)}");

            _requests.Add(typeof(T));

            try
            {
                if (_container.TryGetValue(typeof(T), out Registration registration))
                    return (T)registration.CreateInstanceFrom(this); // создаем сервис и возвращаем его;

                if(_parent != null)
                    return _parent.Resolve<T>();
            }
            
            finally
            {
                _requests.Remove(typeof(T));
            }

            throw new InvalidOperationException($"Registration for {typeof(T)} not exists");
        }
    }
}