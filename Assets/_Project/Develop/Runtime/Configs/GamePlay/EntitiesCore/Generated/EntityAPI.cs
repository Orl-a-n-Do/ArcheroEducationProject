namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
	public partial class Entity
	{
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

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent RigidbodyC => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
			return AddComponent(new Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent() {Value = value}); 
		}

	}
}
