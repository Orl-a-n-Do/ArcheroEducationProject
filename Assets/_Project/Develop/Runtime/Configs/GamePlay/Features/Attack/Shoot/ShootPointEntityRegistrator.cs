using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.Shoot
{
    public class ShootPointEntityRegistrator : MonoEntityRegistrator
    {
        [SerializeField] private Transform _shootPoint;


        public override void Register(Entity entity)
        {
            entity.AddShootPoint(_shootPoint);
        }
    }
}
