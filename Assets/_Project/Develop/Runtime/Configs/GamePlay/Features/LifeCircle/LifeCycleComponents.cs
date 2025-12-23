using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    public class CurrentHealth: IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class MaxHealth : IEntityComponent
    { 
       public ReactiveVariable<float> Value; 

    }

    public class IsDead : IEntityComponent
    {
        public ReactiveVariable<bool> Value;

    }

    public class DeathProcessInitialTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class DeathProcessCurrentTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class InDeathProcess : IEntityComponent
    {
        public ReactiveVariable<bool> Value;

    }

}

