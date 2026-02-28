using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI
{
    public  class AIBrainsContext
    {
        private readonly List<EntityToBrain> _entityToBrains = new();

        public void SetFor(Entity entity, IBrain brain)
        {

            foreach(EntityToBrain item in _entityToBrains)
            {
                if(item.Entity == entity)
                {
                    item.Brain.Disable();
                    item.Brain.Dispose();
                    item.Brain = brain;
                    item.Brain.Enable();
                    return;
                }

            }


            _entityToBrains.Add(new EntityToBrain(entity, brain));
            brain.Enable();


        }
        private class EntityToBrain
        {
            public Entity Entity;
            public IBrain Brain;

            public EntityToBrain(Entity entity, IBrain brain)
            {
                Entity = entity;
                Brain = brain;
            }
        }


    }
}
