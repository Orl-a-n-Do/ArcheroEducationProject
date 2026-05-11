using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    [RequireComponent(typeof(Animator))]

    public class DeadView: EntityView
    {
        private readonly int IsDeadKey = Animator.StringToHash("IsDead");

        [SerializeField] private Animator _animator;

        private IReadOnlyVariable<bool> _isDead;

        private IDisposable _isDeadChangedDisposable;

        public void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }

        protected override void OnEntityStartedWork(Entity entity)
        {
            _isDead = entity.IsDead;

            _isDeadChangedDisposable = _isDead.Subscribe(OnIsDeadChanged);
            UpdateIsMoving(_isDead.Value);
        }

        public override void Cleanup(Entity entity)
        {
            base.Cleanup(entity);

            _isDeadChangedDisposable.Dispose();

        }

        private void OnIsDeadChanged(bool oldIsDead, bool isDead) => UpdateIsMoving(isDead);

        private void UpdateIsMoving(bool value) => _animator.SetBool(IsDeadKey, value);

    }

}

