using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.Shoot
{
    public class InstantShootSystem : IInitializableSystem, IDisposableSystem
    {
        private readonly EntitiesFactory _entitiesFactory;

        private ReactiveEvent _attackDelayEndEvent;

        private Entity _entity;

        private ReactiveVariable<float> _damage;
        private Transform _shootPoint;

        private IDisposable _attackDelayEndDisposable;

        public InstantShootSystem(EntitiesFactory entitiesFactory)
        {
            _entitiesFactory = entitiesFactory;
        }

        public void OnInit(Entity entity)
        {
            _entity = entity;

            _attackDelayEndEvent = entity.AttackDelayTimeEndEvent;


            _damage = entity.InstantAttackDamage;
            _shootPoint = entity.ShootPoint;


            _attackDelayEndDisposable = _attackDelayEndEvent.Subscribe(OnAttackDelayEnd);
        }

        private void OnAttackDelayEnd()
        {
            _entitiesFactory.CreateProjectile(_shootPoint.position, _shootPoint.forward, _damage.Value, _entity);
            
            Debug.Log($"Выстрел, урон:{_damage.Value}, точка выстрела : {_shootPoint.position}");

        }
        public void OnDispose()
        {
            _attackDelayEndDisposable.Dispose();
        }
    }
}
