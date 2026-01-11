using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities;
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

}
