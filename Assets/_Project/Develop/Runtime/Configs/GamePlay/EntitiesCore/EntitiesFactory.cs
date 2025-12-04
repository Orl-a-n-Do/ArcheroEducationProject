using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle;


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

        public Entity CreateGhost(Vector3 position) //Создание и кофигурирование сущностей
        {
           Entity entity = CreateEmpty();

           _monoEntitiesFactory.Create(entity, position, "Entities/Ghost");


            entity
                 .AddMoveDirection()
                 .AddMoveSpeed(new ReactiveVariable<float>(10))
                 .AddRotationDirection()
                 .AddRotationSpeed(new ReactiveVariable<float>(900))
                 .AddMaxHealth(new ReactiveVariable<float>(100))
                 .AddCurrentHealth(new ReactiveVariable<float>(100))
                 .AddIsDead();

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));


            _entitiesLifeContext.Add(entity);


           return entity;
            
        }

        private Entity CreateEmpty() => new Entity();

    }
}
