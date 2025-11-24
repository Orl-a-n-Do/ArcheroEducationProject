using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono
{
    public abstract class MonoEntityRegistrator: MonoBehaviour
    {
        public abstract void Register(Entity entity);// На каждый компонент мы вешаем свой регистратор

    }
}
