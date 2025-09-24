using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Meta.Features.Wallet;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using Assets._Project.Develop.Runtime.Utilities.DataManagement.DatapProvider;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using System.Collections;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Meta.Infrastructure
{
    public class MainMenuBootstrap: SceneBootstrap
    {

        private DIContainer _container;

        private WalletService _walletService;

        private PlayerDataProvider _playerDataProvider;
        private ICoroutinesPerformer _coroutinesPerformer;
      

        //private ReactiveVariable<int> _field;

        //private IDisposable _disposable;

        public override void ProcessRegistration(DIContainer container, IInputSceneArgs sceneArgs = null)
        {
            _container = container;
            MainMenuContextRegistration.Process(_container);
        }

        public override IEnumerator Initialize()
        {
            
            Debug.Log("Инициализация сцены меню");

            _walletService = _container.Resolve<WalletService>();

            _playerDataProvider = _container.Resolve<PlayerDataProvider>();
            _coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();

         
           


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


            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _walletService.Add(CurrencyTypes.Gold, 10);
                Debug.Log("Золота осталось: " + _walletService.GetCurrency(CurrencyTypes.Gold).Value);

            }



            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (_walletService.Enough(CurrencyTypes.Gold, 10))
                {
                    _walletService.Spend(CurrencyTypes.Gold, 10);
                    Debug.Log("Золота осталось: " + _walletService.GetCurrency(CurrencyTypes.Gold).Value);
                }
            }

            if(Input.GetKeyDown(KeyCode.S))
            {
                _coroutinesPerformer.StartPerform(_playerDataProvider.Save());
                Debug.Log("Сохранение было вызвано");
            }


        }

          

    }
}
