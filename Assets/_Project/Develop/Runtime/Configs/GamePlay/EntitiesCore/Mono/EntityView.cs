using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono
{
    public abstract class EntityView: MonoBehaviour
    {
        public void Link(Entity entity)
        {
            if (entity.IsInit)
            {
                OnEntityStartedWork(entity);
                return;
            }

            entity.Initialized += OnEntityStartedWork;
        }

        public virtual void Cleanup(Entity entity)
        {
            entity.Initialized -= OnEntityStartedWork;
        }

        protected abstract void OnEntityStartedWork(Entity entity);
    }
}
