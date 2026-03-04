using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI.States
{
    public interface ITargetSelector
    {
        Entity SelectTargetFrom(IEnumerable<Entity> targets);



    }
}
