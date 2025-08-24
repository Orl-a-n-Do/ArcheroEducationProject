
using UnityEngine;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using System.Collections;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagement;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement; // Import the DI container namespace for dependency injection, импортируем пространство имен контейнера внедрения зависимостей


namespace Assets._Project.Develop.Runtime.Infrastructure.EntryPoint
{
    public class GameEntryPoint : MonoBehaviour
    {

        private void Awake()
        {
            Debug.Log("Старт проекта сетап настройки"); // Debug message to indicate the entry point is initialized, отладочное сообщение для указания на то, что точка входа инициализирована
           
            SetupAppSettings();

            Debug.Log("Процесс регистрации сервисов всего проекта"); // Debug message to indicate UPA settings are set, отладочное сообщение для указания на то, что настройки UPA установлены

            DIContainer container = new DIContainer(); // Create a new instance of the DI container, создаем новый экземпляр контейнера внедрения зависимостей
           
            EntryPointRegistrations.Process(container); // Process the entry point registrations, обрабатываем регистрации точек входа

            container.Resolve<ICoroutinesPerformer>().StartPerform(Initialize(container)); // Start the initialization coroutine using the coroutines performer service, запускаем корутину инициализации с использованием сервиса исполнителя корутин    

        }

        private void SetupAppSettings()
        {
            QualitySettings.vSyncCount = 0; // Disable VSync , отключили вертикальную синхронизацию
            Application.targetFrameRate = 60; // Set target frame rate to 60 FPS, установили целевую частоту кадров в 60 FPS
        }

         private IEnumerator Initialize(DIContainer container)
         {

            Debug.Log("Открываеться штора загрузки");

            Debug.Log("Начинаеться инициализация сервисов");

            yield return container.Resolve<ConfigsProviderService>().LoadAsync();

            yield return new WaitForSeconds(1f);

            Debug.Log("Завершение инициализации сервисов");

            Debug.Log("Закрытие шторы загрузки");

            Debug.Log("Начинаеться перехрод на другую сцену");

        }
    
    }
}