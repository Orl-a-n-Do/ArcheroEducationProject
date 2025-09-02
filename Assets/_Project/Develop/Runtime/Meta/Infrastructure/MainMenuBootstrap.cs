using System.Collections;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Infrastructure;
using UnityEngine;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using UnityEditor.SearchService;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;

namespace Assets._Project.Develop.Runtime.Meta.Infrastructure
{
    public class MainMenuBootstrap: SceneBootstrap
    {

        private DIContainer _container;


        public override IEnumerator Initialize(DIContainer container, IInputSceneArgs sceneArgs)
        {
            _container = container;

            Debug.Log("Инициализация сцены меню");

            yield break;
        }

        public override void Run()
        {
            Debug.Log("Старт сцены меню");
        }

        private void Update()
        { 
            if(Input.GetKeyDown(KeyCode.F))
            {

                SceneSwitcherService sceneSwitcherService = _container.Resolve<SceneSwitcherService>();
                ICoroutinesPerformer coroutinesPerformer =_container.Resolve<ICoroutinesPerformer>();
                coroutinesPerformer.StartPerform(sceneSwitcherService.ProcessSwitchTo(Scenes.Gameplay, new GameplayInputArgs(2)));
            }    
        
        }

    }
}
