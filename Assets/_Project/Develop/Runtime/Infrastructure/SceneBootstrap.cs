using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;
using System.Collections;


namespace Assets._Project.Develop.Runtime.Infrastructure
{
    public abstract class SceneBootstrap: MonoBehaviour
    {
        public abstract IEnumerator Initialize(DIContainer container);
        public abstract void Run();

    }
}
