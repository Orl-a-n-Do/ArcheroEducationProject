namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
	public partial class Entity
	{
		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.BodyCollider BodyColliderC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.BodyCollider>();

		public UnityEngine.CapsuleCollider BodyCollider => BodyColliderC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddBodyCollider(UnityEngine.CapsuleCollider value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.BodyCollider() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactDetectingMask ContactDetectingMaskC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactDetectingMask>();

		public UnityEngine.LayerMask ContactDetectingMask => ContactDetectingMaskC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddContactDetectingMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactDetectingMask() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactCollidersBuffer ContactCollidersBufferC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactCollidersBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> ContactCollidersBuffer => ContactCollidersBufferC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddContactCollidersBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactCollidersBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactEntitiesBuffer ContactEntitiesBufferC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactEntitiesBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity> ContactEntitiesBuffer => ContactEntitiesBufferC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddContactEntitiesBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.ContactEntitiesBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection MoveDirectionC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> MoveDirection => MoveDirectionC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMoveDirection()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMoveDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed MoveSpeedC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> MoveSpeed => MoveSpeedC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMoveSpeed()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMoveSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanMove CanMoveC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanMove>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanMove => CanMoveC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCanMove(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanMove() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationDirection RotationDirectionC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> RotationDirection => RotationDirectionC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRotationDirection()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationDirection() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRotationDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationDirection() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationSpeed RotationSpeedC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> RotationSpeed => RotationSpeedC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRotationSpeed()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationSpeed() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRotationSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.RotationSpeed() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanRotate CanRotateC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanRotate>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanRotate => CanRotateC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCanRotate(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.CanRotate() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.CurrentHealth CurrentHealthC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.CurrentHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> CurrentHealth => CurrentHealthC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCurrentHealth()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.CurrentHealth() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCurrentHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.CurrentHealth() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MaxHealth MaxHealthC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MaxHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> MaxHealth => MaxHealthC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMaxHealth()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MaxHealth() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMaxHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MaxHealth() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.IsDead IsDeadC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.IsDead>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> IsDead => IsDeadC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsDead()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.IsDead() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsDead(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.IsDead() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustDie MustDieC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustDie>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustDie => MustDieC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMustDie(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustDie() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustSelfRelease MustSelfReleaseC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustSelfRelease>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustSelfRelease => MustSelfReleaseC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMustSelfRelease(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.MustSelfRelease() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessInitialTime DeathProcessInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> DeathProcessInitialTime => DeathProcessInitialTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDeathProcessInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessInitialTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDeathProcessInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessCurrentTime DeathProcessCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> DeathProcessCurrentTime => DeathProcessCurrentTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDeathProcessCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessCurrentTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDeathProcessCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DeathProcessCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.InDeathProcess InDeathProcessC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.InDeathProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> InDeathProcess => InDeathProcessC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInDeathProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.InDeathProcess() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInDeathProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.InDeathProcess() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DisableCollidersOnDeath DisableCollidersOnDeathC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DisableCollidersOnDeath>();

		public global::System.Collections.Generic.List<UnityEngine.Collider> DisableCollidersOnDeath => DisableCollidersOnDeathC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDisableCollidersOnDeath()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DisableCollidersOnDeath() { Value = new global::System.Collections.Generic.List<UnityEngine.Collider>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDisableCollidersOnDeath(global::System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle.DisableCollidersOnDeath() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ContactTakeDamage.BodyContactDamage BodyContactDamageC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ContactTakeDamage.BodyContactDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> BodyContactDamage => BodyContactDamageC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddBodyContactDamage()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ContactTakeDamage.BodyContactDamage() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddBodyContactDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ContactTakeDamage.BodyContactDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageRequest TakeDamageRequestC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float> TakeDamageRequest => TakeDamageRequestC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddTakeDamageRequest()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageRequest() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddTakeDamageRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageRequest() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageEvent TakeDamageEventC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float> TakeDamageEvent => TakeDamageEventC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddTakeDamageEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageEvent() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddTakeDamageEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.TakeDamageEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.CanApplyDamage CanApplyDamageC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.CanApplyDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanApplyDamage => CanApplyDamageC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCanApplyDamage(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.ApplyDamage.CanApplyDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent RigidbodyC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent() {Value = value}); 
		}

	}
}
