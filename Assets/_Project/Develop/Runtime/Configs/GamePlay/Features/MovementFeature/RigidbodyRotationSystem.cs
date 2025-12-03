using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature
{
    public class RigidbodyRotationSystem : IInitializableSystem, IUpdatableSystem
    {
        private Rigidbody _rigidbody;

        private ReactiveVariable<float> _rotationSpeed;
        private ReactiveVariable<Vector3> _direction;

        public void OnInit(Entity entity)
        {
            _rigidbody = entity.Rigidbody;
            _rotationSpeed = entity.RotationSpeed;
            _direction = entity.RotationDirection;
        }

        public void OnUpdate(float deltaTime)
        {
           if(_direction.Value == Vector3.zero)
                return;

            Quaternion lookRotation = Quaternion.LookRotation(_direction.Value.normalized);

            float step = _rotationSpeed.Value * deltaTime;

            Quaternion rotation = Quaternion.RotateTowards(_rigidbody.rotation, lookRotation, step);

            _rigidbody.MoveRotation(rotation);

        }
    }
}
