
using UnityEngine;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using System.Collections;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagement;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.LoadingScreen;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.SceneManagement; // Import the DI container namespace for dependency injection, импортируем пространство имен контейнера внедрения зависимостей


namespace Assets._Project.Develop.Runtime.Infrastructure.EntryPoint
{
    public class GameEntryPoint : MonoBehaviour
    {

        private void Awake()
        {
            Debug.Log("Старт проекта сетап настройки"); // Debug message to indicate the entry point is initialized, отладочное сообщение для указания на то, что точка входа инициализирована
           
            SetupAppSettings();

            Debug.Log("Процесс регистрации сервисов всего проекта"); // Debug message to indicate UPA settings are set, отладочное сообщение для указания на то, что настройки UPA установлены

            DIContainer projectContainer = new DIContainer(); // Create a new instance of the DI container, создаем новый экземпляр контейнера внедрения зависимостей
           
            ProjectContextRegistrations.Process(projectContainer); // Process the entry point registrations, обрабатываем регистрации точек входа

            projectContainer.Resolve<ICoroutinesPerformer>().StartPerform(Initialize(projectContainer)); // Start the initialization coroutine using the coroutines performer service, запускаем корутину инициализации с использованием сервиса исполнителя корутин    

        }

        private void SetupAppSettings()
        {
            QualitySettings.vSyncCount = 0; // Disable VSync , отключили вертикальную синхронизацию
            Application.targetFrameRate = 60; // Set target frame rate to 60 FPS, установили целевую частоту кадров в 60 FPS
        }

         private IEnumerator Initialize(DIContainer container)
         {

            ILoadingScreen loadingScreen = container.Resolve<ILoadingScreen>();
            SceneSwitcherService sceneSwitcherService = container.Resolve<SceneSwitcherService>();
            
            loadingScreen.Show();
           

            Debug.Log("Начинаеться инициализация сервисов");

            yield return container.Resolve<ConfigsProviderService>().LoadAsync();

            yield return new WaitForSeconds(1f);

            Debug.Log("Завершение инициализации сервисов");

            loadingScreen.Hide();

            yield return sceneSwitcherService.ProcessSwitchTo(Scenes.MainMenu);

        }
    
    }
}