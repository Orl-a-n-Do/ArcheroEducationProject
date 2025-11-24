using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono
{
    public class MonoEntity: MonoBehaviour // Прослойка между Entity и Unity
    {
        public void Setup(Entity entity)
        {
            MonoEntityRegistrator[] registrators = GetComponentsInChildren<MonoEntityRegistrator>();

            if (registrators != null)
                foreach(MonoEntityRegistrator registrator in registrators)
                        registrator.Register(entity);

            

        }

        public void Cleanup(Entity entity)
        {


        }

    }
}
