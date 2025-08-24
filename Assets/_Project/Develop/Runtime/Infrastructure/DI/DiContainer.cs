
using System;
using System.Collections.Generic;


namespace Assets._Project.Develop.Runtime.Infrastructure.DI
{
    public class DIContainer 
    {
      
        private readonly Dictionary<Type, Registration> _container = new();
        private readonly List<Type> _requests = new();




        public void RegisterAsSingle<T>(Func<DIContainer, T> creator)// каждая зависимость будет в единственном экземпляре;
        {
            Registration registration = new(container => creator.Invoke(container)); // создаем регистрацию;
            _container.Add(typeof(T), registration); // регистрируем в контейнере тип по которому будем запрашивать сервис;

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
            }
            
            finally
            {
                _requests.Remove(typeof(T));
            }

            throw new InvalidOperationException($"Registration for {typeof(T)} not exists");
        }
    }
}