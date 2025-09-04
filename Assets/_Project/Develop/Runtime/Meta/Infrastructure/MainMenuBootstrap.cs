using System.Collections;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Infrastructure;
using UnityEngine;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Utilities.Reactive;


namespace Assets._Project.Develop.Runtime.Meta.Infrastructure
{
    public class MainMenuBootstrap: SceneBootstrap
    {

        private DIContainer _container;
        private ReactiveVariable<int> _field;

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

            _field = new ReactiveVariable<int>(5);
            _field.Subscribe(OnFieldChanged);
        }

        private void OnFieldChanged(int arg1, int arg2)
        {
            Debug.Log($"Поле изменилось. Старое значение - {arg1} , новое - {arg2}");
        }



        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {

                SceneSwitcherService sceneSwitcherService = _container.Resolve<SceneSwitcherService>();
                ICoroutinesPerformer coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();
                coroutinesPerformer.StartPerform(sceneSwitcherService.ProcessSwitchTo(Scenes.Gameplay, new GameplayInputArgs(2)));
            }


            if(Input.GetKeyDown(KeyCode.Space))
            {
                _field.Value++;
            }

        }

    }
}
