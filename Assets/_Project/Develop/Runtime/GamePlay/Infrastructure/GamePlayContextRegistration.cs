
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Enemies;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MainHero;
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


            container.RegisterAsSingle(CreateBrainsFactory);

            container.RegisterAsSingle(CreateAIBrainsContext);


            container.RegisterAsSingle(CreateMainHeroFactory);
            container.RegisterAsSingle(CreateEnemiesFactory);


            container.RegisterAsSingle<IInputService>(CreateDesktopInput);

            container.RegisterAsSingle(CreatemonoEntitiesFactory).NonLazy();

            

        }

        private static EnemiesFactory CreateEnemiesFactory(DIContainer c)
        {
            return new EnemiesFactory(c);

        } 
        private static MainHeroFactory CreateMainHeroFactory(DIContainer c)
        {
            return new MainHeroFactory(c);

        }


        private static DesktopInput CreateDesktopInput(DIContainer c)
        {
            return new DesktopInput();

        }

        private static AIBrainsContext CreateAIBrainsContext(DIContainer c)
        {
            return new AIBrainsContext();

        }

        private static BrainsFactory CreateBrainsFactory(DIContainer c)
        { 
            return new BrainsFactory(c);
        
        
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
