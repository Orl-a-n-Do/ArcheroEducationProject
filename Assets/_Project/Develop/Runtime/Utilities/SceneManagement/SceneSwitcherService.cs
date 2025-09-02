
using System;
using System.Collections;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.LoadingScreen;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using Assets._Project.Develop.Runtime.Infrastructure;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Assets._Project.Develop.Runtime.Utilities.SceneManagement
{
    public class SceneSwitcherService
    {
        private readonly SceneLoaderService _sceneLoaderService;
        private readonly ILoadingScreen _loadingScreen;
        private readonly DIContainer _container;

        public SceneSwitcherService(
            SceneLoaderService sceneLoaderService,
            ILoadingScreen loadingScreen,
            DIContainer container)
        {
            _sceneLoaderService = sceneLoaderService;
            _loadingScreen = loadingScreen;
            _container = container;
        }


        public IEnumerator ProcessSwitchTo(string sceneName, IInputSceneArgs sceneArgs = null)
        {
             Debug.Log($"SceneLoader: {_sceneLoaderService != null}, LoadingScreen: {_loadingScreen != null}");
            _loadingScreen.Show();

            yield return _sceneLoaderService.LoadAsync(Scenes.Empty);
            yield return _sceneLoaderService.LoadAsync(sceneName);


            SceneBootstrap sceneBootstrap = Object.FindObjectOfType<SceneBootstrap>();

            if (sceneBootstrap == null)
                throw new NullReferenceException(nameof(sceneBootstrap) + " not found");

            yield return sceneBootstrap.Initialize(_container, sceneArgs);

            _loadingScreen.Hide();

            sceneBootstrap.Run();

        }

    }
}