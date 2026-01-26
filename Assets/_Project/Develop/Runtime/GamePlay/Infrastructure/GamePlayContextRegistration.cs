
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GamePlay.Infrastructure
{
    public class GamePlayContextRegistration
    {
        public static void Process(DIContainer container, GameplayInputArgs args)
        {

            container.RegisterAsSingle(CreateEntitiesFactory);
            container.RegisterAsSingle(CreateEntitiesLifeContext);

            container.RegisterAsSingle(CreateCollidersRegistryService);



            container.RegisterAsSingle(CreatemonoEntitiesFactory).NonLazy();

            

        }

        private static CollidersRegistryService CreateCollidersRegistryService (DIContainer c)
        {
            return new CollidersRegistryService();
                
        }

        private static MonoEntitiesFactory CreatemonoEntitiesFactory(DIContainer c)
        {

            return new MonoEntitiesFactory(
                c.Resolve<ResourcesAssetsLoader>(),
                c.Resolve<EntitiesLifeContext>(),
                c.Resolve<CollidersRegistryService>());
          
        }



        private static EntitiesLifeContext CreateEntitiesLifeContext(DIContainer c)
        {
            return new EntitiesLifeContext();

        }

        private static EntitiesFactory CreateEntitiesFactory(DIContainer c)
        {     
            return new EntitiesFactory(c);  

        }
    }


}
