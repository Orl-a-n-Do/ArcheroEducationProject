using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors
{
    public class BodyColliderRegistrator : MonoEntityRegistrator
  {
        [SerializeField] private CapsuleCollider _body;


        public override void Register(Entity entity)
        {
            entity.AddBodyCollider(_body);    
        }

    }


}
