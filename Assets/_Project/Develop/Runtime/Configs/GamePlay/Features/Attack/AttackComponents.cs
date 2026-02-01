using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack
{
    public class StartAttackRequest : IEntityComponent
    {
        public ReactiveEvent Value;

    }


    public class StartAttackEvent : IEntityComponent
    {
        public ReactiveEvent Value;


    }

    public class CanStartAttack : IEntityComponent
    {
        public ICompositeCondition Value;

    }

    public class EndAttackEvent : IEntityComponent
    {
        public ReactiveEvent Value;

    }

    public class AttackProcessInitialTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;


    }
    public class AttackProcessCurrentTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }
    
    public class InAttackProcess : IEntityComponent
    {
        public ReactiveVariable<bool> Value;

    }

    public class AttackDelayTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class AttackDelayTimeEndEvent : IEntityComponent
    {
        public ReactiveEvent Value;

    }
    public class InstantAttackDamage : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class ShootPoint : IEntityComponent
    {
        public Transform Value;

    }

    public class MustCancelAttack : IEntityComponent
    {
        public ICompositeCondition Value;

    }


    public class AttackCanceledEvent : IEntityComponent
    {
        public ReactiveEvent Value;

    }

    public class AttackCooldownInitialTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }


    public class AttackCooldownCurrentTime : IEntityComponent
    {
        public ReactiveVariable<float> Value;

    }

    public class InAttackCooldown : IEntityComponent
    {
        public ReactiveVariable<bool> Value;

    }


}
