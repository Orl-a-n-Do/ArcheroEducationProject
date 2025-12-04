
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace ArcheroEducationProject.Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    public class DeathSystem : IInitializableSystem, IUpdatableSystem
    {
        private ReactiveVariable<bool> _isDead;

        private ReactiveVariable<float> _currentHealth;


        public void OnInit(Entity entity)
        {
            _isDead = entity.IsDead;
            _currentHealth = entity.CurrentHealth;



        }

        public void OnUpdate(float deltaTime)
        {
            if (_isDead.Value)
                return;



            if (_currentHealth.Value <= 0)
            {
                _isDead.Value = true;
                Debug.Log("Я умер(");


            }
        }
    }
}