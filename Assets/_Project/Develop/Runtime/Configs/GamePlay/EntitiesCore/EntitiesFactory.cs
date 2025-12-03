using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
    public class EntitiesFactory
    {
        private readonly DIContainer _container;
        private readonly EntitiesLifeContext _entitiesLifeContext;

        private readonly MonoEntitiesFactory _monoEntitiesFactory;

        public EntitiesFactory(DIContainer container)
        {
            _container = container;
            _entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = _container.Resolve<MonoEntitiesFactory>();
        }

        public Entity CreateTestEntity(Vector3 position) //Создание и кофигурирование сущностей
        {
           Entity entity = CreateEmpty();

           _monoEntitiesFactory.Create(entity, position, "Entities/TestEntity");




            entity
                 .AddMoveDirection()
                 .AddMoveSpeed(new ReactiveVariable<float>(10));

            entity.AddSystem(new RigidbodyMovementSystem());

            _entitiesLifeContext.Add(entity);


           return entity;
            
        }

        private Entity CreateEmpty() => new Entity();

    }
}
