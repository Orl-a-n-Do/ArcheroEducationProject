using System;
using System.Collections;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Configs.GamePlay;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Meta.Features.Wallet;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.GamePlay.Infrastructure
{
    internal class GameplayBootstrap : SceneBootstrap
    {
        private DIContainer _container;
        private GameplayInputArgs _inputArgs;

        private WalletService _walletService;

        [SerializeField] private TestGamePlay _testGamePlay;

        private EntitiesLifeContext _entitiesLifeContext;


        public override void ProcessRegistration(DIContainer container, IInputSceneArgs sceneArgs = null)
        {
            _container = container;

            if (sceneArgs is not GameplayInputArgs gameplayInputArgs)
                throw new ArgumentException($"{nameof(sceneArgs)} is not match with {typeof(GameplayInputArgs)} type");

            _inputArgs = gameplayInputArgs;

            GamePlayContextRegistration.Process(_container, _inputArgs);

        }


        public override IEnumerator Initialize()
        {

            Debug.Log($"Вы попали на уровень {_inputArgs.LevelNumber}");
            
            Debug.Log("Инициализация геймплейной сцены");

            _walletService = _container.Resolve<WalletService>();

            _entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();


            _testGamePlay.Initialize(_container);

            yield break;
        }



      
        public override void Run()
        {
            Debug.Log("Старт геймплейной сцены");
            _testGamePlay.Run();
        }


        private void Update()
        {
            _entitiesLifeContext?.Update(Time.deltaTime);




            if (Input.GetKeyDown(KeyCode.F))
            {

                SceneSwitcherService sceneSwitcherService = _container.Resolve<SceneSwitcherService>();
                ICoroutinesPerformer coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();
                coroutinesPerformer.StartPerform(sceneSwitcherService.ProcessSwitchTo(Scenes.MainMenu));
            }

        }
    }
}
