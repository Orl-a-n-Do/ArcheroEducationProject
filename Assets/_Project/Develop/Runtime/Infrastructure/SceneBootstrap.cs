using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;
using System.Collections;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;


namespace Assets._Project.Develop.Runtime.Infrastructure
{
    public abstract class SceneBootstrap: MonoBehaviour
    {
        public abstract void ProcessRegistration(DIContainer container, IInputSceneArgs sceneArgs = null);


        public abstract IEnumerator Initialize();
        public abstract void Run();

    }
}
