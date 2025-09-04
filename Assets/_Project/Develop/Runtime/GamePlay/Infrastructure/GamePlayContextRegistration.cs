
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GamePlay.Infrastructure
{
    public class GamePlayContextRegistration
    {
        public static void Process(DIContainer container, GameplayInputArgs args)
        {

            Debug.Log("Процесс регистрации сервисов на сцене геймплея");

        }
    }
}
