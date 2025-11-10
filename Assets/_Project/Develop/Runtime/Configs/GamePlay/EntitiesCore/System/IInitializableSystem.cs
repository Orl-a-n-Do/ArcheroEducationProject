namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System
{
    public interface IInitializableSystem: IEntitySystem
    {
        void OnInit(Entity entity);

    }
}
