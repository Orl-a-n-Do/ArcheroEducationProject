namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System
{
    public interface IUpdatableSystem: IEntitySystem // Если системе нужно обновляться для выполнения логики , реализуеться данный интерфейс
    {
        void OnUpdate(float deltaTime);

    }
}
