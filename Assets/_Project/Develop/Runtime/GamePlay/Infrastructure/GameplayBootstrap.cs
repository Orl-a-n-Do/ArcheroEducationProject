using System;
using System.Collections;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.GamePlay.Infrastructure
{
    internal class GameplayBootstrap : SceneBootstrap
    {
        private DIContainer _container;



        public override IEnumerator Initialize(DIContainer container, IInputSceneArgs sceneArgs)
        {
            _container = container;

            if (sceneArgs is not GameplayInputArgs gameplayInputArgs)
                throw new ArgumentException($"{nameof(sceneArgs)} is not match with {typeof(GameplayInputArgs)} type");

            Debug.Log($"Вы попали на уровень {gameplayInputArgs.LevelNumber}");
            


            Debug.Log("Инициализация геймплейной сцены");

            yield break;
        }

        public override void Run()
        {
            Debug.Log("Старт геймплейной сцены");
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                SceneSwitcherService sceneSwitcherService = _container.Resolve<SceneSwitcherService>();
                ICoroutinesPerformer coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();
                coroutinesPerformer.StartPerform(sceneSwitcherService.ProcessSwitchTo(Scenes.MainMenu));
            }

        }
    }
}
