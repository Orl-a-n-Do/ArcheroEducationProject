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
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.Shoot;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Entities;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.TeamsFeature;


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


        public Entity CreateHero(Vector3 position, HeroConfig config) //Создание и кофигурирование сущностей
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Hero");


            entity
                 .AddMoveDirection()
                 .AddMoveSpeed(new ReactiveVariable<float>(config.MoveSpeed))
                 .AddIsMoving()
                 .AddRotationDirection()
                 .AddRotationSpeed(new ReactiveVariable<float>(config.RotationSpeed))
                 .AddMaxHealth(new ReactiveVariable<float>(config.MaxHealth))
                 .AddCurrentHealth(new ReactiveVariable<float>(config.MaxHealth))
                 .AddIsDead()
                 .AddInDeathProcess()
                 .AddDeathProcessInitialTime(new ReactiveVariable<float>(config.DeathProcessTime))
                 .AddDeathProcessCurrentTime()
                 .AddTakeDamageRequest()
                 .AddTakeDamageEvent()
                 .AddAttackProcessInitialTime(new ReactiveVariable<float>(config.AttackProcessTime))
                 .AddAttackProcessCurrentTime()
                 .AddInAttackProcess()
                 .AddStartAttackRequest()
                 .AddStartAttackEvent()
                 .AddEndAttackEvent()
                 .AddAttackDelayTime(new ReactiveVariable<float>(config.AttackDelayTime))
                 .AddAttackDelayTimeEndEvent()
                 .AddInstantAttackDamage(new ReactiveVariable<float>(config.InstantAttackDamage))
                 .AddAttackCanceledEvent()
                 .AddAttackCooldownInitialTime(new ReactiveVariable<float>(config.AttackCooldown))
                 .AddAttackCooldownCurrentTime()
                 .AddInAttackCooldown();
                 

                 
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


            ICompositeCondition canStartAttack = new CompositeCondition()
                   .Add(new FuncCondition(() => entity.IsDead.Value == false))
                   .Add(new FuncCondition(() => entity.InAttackProcess.Value == false))
                   .Add(new FuncCondition(() => entity.IsMoving.Value == false))
                   .Add(new FuncCondition(() => entity.InAttackCooldown.Value == false));

            ICompositeCondition mustCancelAttack = new CompositeCondition(LogicOperations.Or)
                   .Add(new FuncCondition(() => entity.IsDead.Value ))
                   .Add(new FuncCondition(() => entity.IsMoving.Value ));



            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease)
                .AddCanApplyDamage(canApplyDamage)
                .AddCanStartAttack(canStartAttack)
                .AddMustCancelAttack(mustCancelAttack);




            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new AttackCancelSystem())
                .AddSystem(new StartAttackSystem())
                .AddSystem(new AttackProcessTimerSystem())
                .AddSystem (new AttackDelayEndTriggerSystem())
                .AddSystem(new InstantShootSystem(this))
                .AddSystem(new EndAttackSystem())
                .AddSystem(new AttackCooldownTimerSystem())
                .AddSystem(new ApplyDamageSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));



           


            return entity;

        }






        public Entity CreateGhost(Vector3 position, GhostConfig config) //Создание и кофигурирование сущностей
        {
           Entity entity = CreateEmpty();

           _monoEntitiesFactory.Create(entity, position, "Entities/Ghost");


            entity
                 .AddMoveDirection()
                 .AddMoveSpeed(new ReactiveVariable<float>(config.MoveSpeed))
                 .AddIsMoving()
                 .AddRotationDirection()
                 .AddRotationSpeed(new ReactiveVariable<float>(config.RotationSpeed))
                 .AddMaxHealth(new ReactiveVariable<float>(config.MaxHealth))
                 .AddCurrentHealth(new ReactiveVariable<float>(config.MaxHealth))
                 .AddIsDead()
                 .AddInDeathProcess()
                 .AddDeathProcessInitialTime(new ReactiveVariable<float>(config.DeathProcessTime))
                 .AddDeathProcessCurrentTime()
                 .AddTakeDamageRequest()
                 .AddTakeDamageEvent()
                 .AddContactDetectingMask(Layers.CharactersMask)
                 .AddContactCollidersBuffer(new Buffer<Collider>(64))
                 .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                 .AddBodyContactDamage(new ReactiveVariable<float>(config.BodyContactDamage));

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
                .AddSystem(new DisableCollidersOnDeathSystem())
                .AddSystem(new DeathProcessTimerSystem())
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));



           // _entitiesLifeContext.Add(entity);


           return entity;
            
        }



        public Entity CreateProjectile(Vector3 position, Vector3 direction, float damage, Entity owner) //Создание и кофигурирование сущностей
        {
            Entity entity = CreateEmpty();

            _monoEntitiesFactory.Create(entity, position, "Entities/Projectile");


            entity
                 .AddMoveDirection(new ReactiveVariable<Vector3>(direction))
                 .AddMoveSpeed(new ReactiveVariable<float>(10))
                 .AddIsMoving()
                 .AddRotationDirection(new ReactiveVariable<Vector3>(direction))
                 .AddRotationSpeed(new ReactiveVariable<float>(9999))
                 .AddIsDead()
                 .AddContactDetectingMask(Layers.CharactersMask | Layers.EnviromentMask)
                 .AddContactCollidersBuffer(new Buffer<Collider>(64))
                 .AddContactEntitiesBuffer(new Buffer<Entity>(64))
                 .AddBodyContactDamage(new ReactiveVariable<float>(damage))
                 .AddDeathMask(Layers.EnviromentMask)
                 .AddIsTouchDeathMask()
                 .AddIsTouchAnotherTeam()
                 .AddTeam(new ReactiveVariable<Teams>(owner.Team.Value));


            ICompositeCondition canMove = new CompositeCondition()
                   .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition canRotate = new CompositeCondition()
                  .Add(new FuncCondition(() => entity.IsDead.Value == false));

            ICompositeCondition mustDie = new CompositeCondition(LogicOperations.Or)
                 .Add(new FuncCondition(() => entity.IsTouchDeathMask.Value))
                 .Add(new FuncCondition(() => entity.IsTouchAnotherTeam.Value));

            ICompositeCondition mustSelfRelease = new CompositeCondition()
                 .Add(new FuncCondition(() => entity.IsDead.Value));


            entity
                .AddCanMove(canMove)
                .AddCanRotate(canRotate)
                .AddMustDie(mustDie)
                .AddMustSelfRelease(mustSelfRelease);
               




            entity
                .AddSystem(new RigidbodyMovementSystem())
                .AddSystem(new RigidbodyRotationSystem())
                .AddSystem(new BodyContactsDetectingSystem())
                .AddSystem(new BodyContactsEntitiesFilterSystem(_collidersRegistryService))
                .AddSystem(new DealDamageOnContactSystem())     
                .AddSystem(new DeathMaskTouchDetectorSystem())
                .AddSystem(new DeathMaskTouchDetectorSystem())
                .AddSystem(new AnotherTeamTouchDetectorSystem())
                .AddSystem(new DeathSystem())
                .AddSystem(new DisableCollidersOnDeathSystem())              
                .AddSystem(new SelfReleaseSystem(_entitiesLifeContext));



            _entitiesLifeContext.Add(entity);


            return entity;

        }

        private Entity CreateEmpty() => new Entity();

    }
}
