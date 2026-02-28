using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Common
{
    public class TransformEntityRegistrator : MonoEntityRegistrator
    {
        public override void Register(Entity entity)
        {
           entity.AddTransform(transform);
        }
    }
}
