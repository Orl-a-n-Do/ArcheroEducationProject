using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors
{
  public class BodyCollider: IEntityComponent
  {
        public CapsuleCollider Value;

  }

  public class ContactDetectingMask: IEntityComponent
  {
        public LayerMask Value;

  }

  public class ContactCollidersBuffer : IEntityComponent
  {
        public Buffer<Collider> Value;

  }


  public class ContactEntitiesBuffer : IEntityComponent
  {
     public Buffer<Entity> Value;

  }

  public class DeathMask : IEntityComponent
  {
        public LayerMask Value;

  }

  public class IsTouchDeathMask : IEntityComponent
  {
        public ReactiveVariable<bool> Value;

  }


  public class IsTouchAnotherTeam : IEntityComponent
  {
        public ReactiveVariable<bool> Value;

  }

}
