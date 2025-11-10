using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
    public class EntitiesFactory
    {
        private readonly DIContainer _container;

        public EntitiesFactory(DIContainer container)
        {
            _container = container;
        }

        public Entity CreateTestEntity() //Создание и кофигурирование сущностей
        {
           Entity entity = CreateEmpty();
            
           entity
                .AddComponent(new MoveDirection() { Value = new ReactiveVariable<Vector3>(Vector3.forward) })
                .AddComponent(new MoveSpeed() { Value = new ReactiveVariable<float>(10) });

            entity.AddSystem(new MovementSystem());

           return entity;
            
        }

        private Entity CreateEmpty() => new Entity();

    }
}
