using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature
{
    public class MovementSystem : IInitializableSystem, IUpdatableSystem
    {

        private ReactiveVariable<Vector3> _moveDirection;
        private ReactiveVariable<float> _moveSpeed;



        public void OnInit(Entity entity)
        {
            _moveDirection = entity.GetComponent<MoveDirection>().Value;
            _moveSpeed = entity.GetComponent<MoveSpeed>().Value;
        }

        public void OnUpdate(float deltaTime)
        {
           
           Vector3 velocity = _moveDirection.Value.normalized * _moveSpeed.Value;

           Debug.Log("Применяемая скорость :" + velocity.ToString());

        }
    }
}
