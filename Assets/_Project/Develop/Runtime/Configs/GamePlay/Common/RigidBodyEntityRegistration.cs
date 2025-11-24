using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Common
{
    public class RigidBodyEntityRegistration : MonoEntityRegistrator
    {
        public override void Register(Entity entity)
        {
            entity.AddComponent(new RigidbodyComponent() { Value = GetComponent<Rigidbody>() });
        }
    }
}
