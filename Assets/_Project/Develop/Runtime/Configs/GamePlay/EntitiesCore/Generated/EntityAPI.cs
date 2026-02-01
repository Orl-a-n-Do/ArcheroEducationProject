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

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.DeathMask DeathMaskC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.DeathMask>();

		public UnityEngine.LayerMask DeathMask => DeathMaskC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddDeathMask(UnityEngine.LayerMask value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.DeathMask() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.IsTouchDeathMask IsTouchDeathMaskC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.IsTouchDeathMask>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> IsTouchDeathMask => IsTouchDeathMaskC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsTouchDeathMask()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.IsTouchDeathMask() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsTouchDeathMask(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors.IsTouchDeathMask() {Value = value}); 
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

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.IsMoving IsMovingC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.IsMoving>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> IsMoving => IsMovingC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsMoving()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.IsMoving() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddIsMoving(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.IsMoving() {Value = value}); 
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

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackRequest StartAttackRequestC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackRequest => StartAttackRequestC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddStartAttackRequest()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackRequest() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddStartAttackRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackRequest() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackEvent StartAttackEventC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackEvent => StartAttackEventC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddStartAttackEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackEvent() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddStartAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.StartAttackEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.CanStartAttack CanStartAttackC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.CanStartAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition CanStartAttack => CanStartAttackC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddCanStartAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.CanStartAttack() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.EndAttackEvent EndAttackEventC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.EndAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent EndAttackEvent => EndAttackEventC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddEndAttackEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.EndAttackEvent() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddEndAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.EndAttackEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessInitialTime AttackProcessInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> AttackProcessInitialTime => AttackProcessInitialTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackProcessInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessInitialTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackProcessInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessCurrentTime AttackProcessCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> AttackProcessCurrentTime => AttackProcessCurrentTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackProcessCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessCurrentTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackProcessCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackProcessCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackProcess InAttackProcessC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> InAttackProcess => InAttackProcessC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInAttackProcess()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackProcess() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInAttackProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackProcess() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTime AttackDelayTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> AttackDelayTime => AttackDelayTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackDelayTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackDelayTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTimeEndEvent AttackDelayTimeEndEventC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTimeEndEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackDelayTimeEndEvent => AttackDelayTimeEndEventC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackDelayTimeEndEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTimeEndEvent() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackDelayTimeEndEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackDelayTimeEndEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InstantAttackDamage InstantAttackDamageC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InstantAttackDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> InstantAttackDamage => InstantAttackDamageC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInstantAttackDamage()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InstantAttackDamage() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInstantAttackDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InstantAttackDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.ShootPoint ShootPointC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.ShootPoint>();

		public UnityEngine.Transform ShootPoint => ShootPointC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddShootPoint(UnityEngine.Transform value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.ShootPoint() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.MustCancelAttack MustCancelAttackC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.MustCancelAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition MustCancelAttack => MustCancelAttackC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddMustCancelAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositeCondition value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.MustCancelAttack() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCanceledEvent AttackCanceledEventC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCanceledEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackCanceledEvent => AttackCanceledEventC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCanceledEvent()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCanceledEvent() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCanceledEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCanceledEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownInitialTime AttackCooldownInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> AttackCooldownInitialTime => AttackCooldownInitialTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCooldownInitialTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownInitialTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCooldownInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownCurrentTime AttackCooldownCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> AttackCooldownCurrentTime => AttackCooldownCurrentTimeC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCooldownCurrentTime()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownCurrentTime() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddAttackCooldownCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<float> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.AttackCooldownCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackCooldown InAttackCooldownC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackCooldown>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> InAttackCooldown => InAttackCooldownC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInAttackCooldown()
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackCooldown() { Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool>() }); 
		}

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddInAttackCooldown(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<bool> value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Attack.InAttackCooldown() {Value = value}); 
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
