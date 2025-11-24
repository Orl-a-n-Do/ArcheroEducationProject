using Assets._Project.Develop.Runtime.Configs.GamePlay.Common;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
    public partial class Entity
    {
        
        public Rigidbody Rigidbody => RigidbodyC.Value;

        public Entity AddRigidbody(Rigidbody value)
        {
            return AddComponent(new RigidbodyComponent() { Value = value });

        }

        
        public ReactiveVariable<Vector3> MoveDirection => MoveDirectionC.Value;

        public Entity AddMoveDirection(ReactiveVariable<Vector3> value)
        {
            return AddComponent(new MoveDirection() { Value = value });

        }
        public Entity AddMoveDirection()
        {
            return AddComponent(new MoveDirection() { Value = new ReactiveVariable<Vector3>() });

        }
    }
}
