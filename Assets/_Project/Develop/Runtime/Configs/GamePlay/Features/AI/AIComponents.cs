using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI
{
    
    public class CurrentTarget: IEntityComponent
    {
        public ReactiveVariable<Entity> Value;

    }


}
