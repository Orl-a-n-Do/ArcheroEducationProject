using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Utilities;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ContactTakeDamage;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
    public class EntitiesFactory
    {
        private readonly DIContainer _container;
        private readonly EntitiesLifeContext _entitiesLifeContext;
        private readonly CollidersRegistryService _collidersRegistryService;
        private readonly MonoEntitiesFactory _monoEntitiesFactory;

        public EntitiesFactory(DIContainer container)
        {
            _container = container;
            _entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();
            _monoEntitiesFactory = _container.Resolve<MonoEntitiesFactory>();
            _collidersRegistryService = _container.Resolve<CollidersRegistryService>();
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
                 .AddIsDead()
                 .AddInDeathProcess()
                 .AddDeathProcessInitialTime(new ReactiveVariable<float>(2))
                 .AddDeathProcessCurrentTime()
                 .AddTakeDamageRequest()
                 .AddTakeDamageEvent()
                 .AddContactDetectingMask(1 << LayerMask.NameToLayer("Characters"))
                 .AddContactCollidersBuffer(new Buffer<Collider>(64))
                 .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                 .AddBodyContactDamage(new ReactiveVariable<float>(50));

            ICompositeCondition canMove = new CompositeCondition()
                   .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                  .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition mustDie = new CompositeCondition()
                 .Add(new FuncCondition(() => entity.CurrentHealth.Value <= 0));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                 .Add(new FuncCondition(() => entity.IsDead.Value))
                 .Add(new FuncCondition(() => entity.InDeathProcess.Value == false));


            ICompositeCondition canApplyDamage = new CompositeCondition()
                   .Add(new FuncCondition(() => entity.IsDead.Value == false));


            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease)
                .AddCanApplyDamage(canApplyDamage);
                

            

            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))
                .AddSystem(new DealDamageOnContactSystem())
                .AddSystem(new ApplyDamageSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));



            _entitiesLifeContext.Add(entity);


           return entity;
            
        }

        private Entity CreateEmpty() => new Entity();

    }
}
