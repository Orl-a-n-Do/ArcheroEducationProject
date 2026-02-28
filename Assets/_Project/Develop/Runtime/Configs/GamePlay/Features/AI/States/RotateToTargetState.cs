using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI.States
{
    public class RotateToTargetState : State, IUpdatableState
    {
        private ReactiveVariable<Vector3> _rotationDirection;
        private ReactiveVariable<Entity> _currentTarget;
        private Transform _transform;

        public RotateToTargetState(Entity entity)
        {
            _rotationDirection = entity.RotationDirection;
            _currentTarget = entity.CurrentTarget;
            

        }

        public void Update(float deltaTime)
        {
            
        }
    }
}
