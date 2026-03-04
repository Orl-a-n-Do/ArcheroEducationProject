using System.Collections.Generic;
using System.Linq;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI.States
{
    public class NearestDamageableTargetSelector : ITargetSelector
    {
        private Entity _source;
        private Transform _sourceTransform;

        public NearestDamageableTargetSelector(Entity entity)
        {
            _source = entity;
            _sourceTransform = entity.Transform;
        }

        public Entity SelectTargetFrom(IEnumerable<Entity> targets)
        {
            IEnumerable<Entity> selectTargets = targets.Where(target =>
            {
               bool result = target.HasComponent<TakeDamageRequest>();

                if(target.TryGetCanApplyDamage(out ICompositeCondition canApplyDamage))
                {
                    result = result && canApplyDamage.Evaluate();
                }

                result = result && (target != _source);

                return result;

            });

            if(selectTargets.Any() == false) 
                return null;


            Entity closestTarget = selectTargets.First();
            float minDistance = GetDistanceTo(closestTarget);

            foreach (Entity target in selectTargets)
            {
                float distance = GetDistanceTo(target);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTarget = target;
                }

            }

            return closestTarget;
        }


        private float GetDistanceTo(Entity target) => (_sourceTransform.position - target.Transform.position).magnitude;
       
    }
}
