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
        private readonly List<EntityToBrain> entityToBrains = new();
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
