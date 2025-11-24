namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore
{
	public partial class Entity
	{
		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection MoveDirectionС => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveDirection>();

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed MoveSpeedС => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature.MoveSpeed>();

		public Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent RigidbodyС => GetComponent<Assets._Project.Develop.Runtime.Configs.GamePlay.Common.RigidbodyComponent>();

	}
}
