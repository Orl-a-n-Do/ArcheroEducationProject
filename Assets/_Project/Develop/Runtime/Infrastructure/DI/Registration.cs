
using System;


namespace Assets._Project.Develop.Runtime.Infrastructure.DI
{
    public class Registration // будем хранить способ создания сервиса;
    {
        private Func<DIContainer, object> _creator; // фабрика для создания сервиса;
        private object _cashedInstance; // для кэширования сервиса после его первого создания;

        public Registration(Func<DIContainer, object> creator) => _creator = creator;

        public object CreateInstanceFrom(DIContainer container)
        {           
            if (_cashedInstance != null)
                 return _cashedInstance;

            if (_creator == null)
                throw new InvalidOperationException("Not has instance or creator");

            _cashedInstance = _creator.Invoke(container);

            return _cashedInstance;
        }


    }
}