
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace ArcheroEducationProject.Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    public class DeathSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<bool> _isDead;
        private ICompositeCondition _mustDie;


        public void OnInit(Entity entity)
        {
            _isDead = entity.IsDead;
            _mustDie = entity.MustDie;



        }

        public void OnUpdate(float deltaTime)
        {
            if (_isDead.Value)
                return;

            if (_mustDie.Evaluate())
                _isDead.Value = true;

        }
    }
}