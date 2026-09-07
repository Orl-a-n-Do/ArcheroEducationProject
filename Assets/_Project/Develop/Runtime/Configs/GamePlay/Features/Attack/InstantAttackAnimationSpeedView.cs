using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Gameplay.Features.Attack
{
    [RequireComponent(typeof(Animator))]
    public class InstantAttackAnimationSpeedView : EntityView
    {
        private readonly int _attackAnimationSpeedMultiplierKey = Animator.StringToHash("AttackAnimationSpeedMultiplier");

        [SerializeField] private AnimationClip _animationClip;
        [SerializeField] private Animator _animator;

        private ReactiveVariable<float> _attackProcessTime;

        #region Сообщение Unity | Ссылок: 0
        private void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }
        #endregion

        protected override void OnEntityStartedWork(Entity entity)
        {
            _attackProcessTime = entity.AttackProcessInitialTime;

            _animator.SetFloat(_attackAnimationSpeedMultiplierKey, _animationClip.length / _attackProcessTime.Value);
        }
    }
}
