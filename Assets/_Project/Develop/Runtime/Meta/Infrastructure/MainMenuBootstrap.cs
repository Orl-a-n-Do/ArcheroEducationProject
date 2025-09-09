using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Meta.Infrastructure
{
    public class MainMenuBootstrap: SceneBootstrap
    {

        private DIContainer _container;

        private ReactiveVariable<int> _field;

        private IDisposable _disposable;

        public override void ProcessRegistration(DIContainer container, IInputSceneArgs sceneArgs = null)
        {
            _container = container;
            MainMenuContextRegistration.Process(_container);
        }

        public override IEnumerator Initialize()
        {
            
            Debug.Log("Инициализация сцены меню");

            yield break;
        }


        public override void Run()
        {
            Debug.Log("Старт сцены меню");

        }


        


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                SceneSwitcherService sceneSwitcherService = _container.Resolve<SceneSwitcherService>();
                ICoroutinesPerformer coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();
                coroutinesPerformer.StartPerform(sceneSwitcherService.ProcessSwitchTo(Scenes.Gameplay, new GameplayInputArgs(2)));
            }


           
        }

    }
}
