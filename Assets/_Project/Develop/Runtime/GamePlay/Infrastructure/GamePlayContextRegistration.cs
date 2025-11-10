
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GamePlay.Infrastructure
{
    public class GamePlayContextRegistration
    {
        public static void Process(DIContainer container, GameplayInputArgs args)
        {

            container.RegisterAsSingle(CreateEntitiesFactory);
            

        }

        private static EntitiesFactory CreateEntitiesFactory(DIContainer c)
        {     
            return new EntitiesFactory(c);  

        }
    }


}
