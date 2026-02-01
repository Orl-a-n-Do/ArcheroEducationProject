using UnityEngine;
using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack
{
    public class AttackCooldownTimerSystem : IInitializableSystem, IDisposableSystem, IUpdatableSystem
    {
        private ReactiveVariable<float> _currentTime;
        private ReactiveVariable<float> _intialTime;
        private ReactiveVariable<bool> _inAttackCooldown;

        private ReactiveEvent _endAttackEvent;


        private IDisposable _endAttackEventDisposable;


        public void OnInit(Entity entity)
        {
            _currentTime = entity.AttackCooldownCurrentTime;
            _intialTime = entity.AttackCooldownInitialTime;
            _inAttackCooldown = entity.InAttackCooldown;
            _endAttackEvent = entity.EndAttackEvent;

            _endAttackEventDisposable = _endAttackEvent.Subscribe(OnEndAttack);

        }

        private void OnEndAttack()
        {
            Debug.Log("Кулдаун начался!");
            _currentTime.Value = _intialTime.Value;
            _inAttackCooldown.Value = true;
        }

      

        public void OnUpdate(float deltaTime)
        {
            if (_inAttackCooldown.Value == false)
                return;

            _currentTime.Value -= deltaTime;

            if (CooldownIsOver())
            {
                _inAttackCooldown.Value = false;
                Debug.Log("Кулдаун закончился");
            }
        }

        private bool CooldownIsOver() => _currentTime.Value <= 0;
        

        public void OnDispose()
        {
            _endAttackEventDisposable.Dispose();
        }

    }

}
