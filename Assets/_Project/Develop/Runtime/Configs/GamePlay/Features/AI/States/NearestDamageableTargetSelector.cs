using System.Collections.Generic;
using System.Linq;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
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
                return false;

            });

            return null;
        }
    }
}
