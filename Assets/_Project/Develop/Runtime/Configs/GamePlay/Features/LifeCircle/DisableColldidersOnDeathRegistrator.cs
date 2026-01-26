using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    public class DisableColldidersOnDeathRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private List<Collider> _colliders;

        public override void Register(Entity entity)
        {
            entity.AddDisableCollidersOnDeath(_colliders);
        }
    }
}

