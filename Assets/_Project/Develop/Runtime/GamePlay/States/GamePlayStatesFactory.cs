using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.StagesFeatures;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Meta.Features.LevelsProgression;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using Assets._Project.Develop.Runtime.Utilities.DataManagement.DatapProvider;
using Assets._Project.Develop.Runtime.Utilities.SceneManagement;

namespace Assets._Project.Develop.Runtime.GamePlay.States
{
    public class GamePlayStatesFactory
    {
        private readonly DIContainer _container;

        public GamePlayStatesFactory(DIContainer container)
        {
            _container = container;
        }

        public PreperationState CreatePreperationState()
        {
            return new PreperationState(_container.Resolve<PreperationTriggerService>());
        }

        public StageProcessState CreateStageProcessState()
        {
            return new StageProcessState(_container.Resolve<StageProviderService>());

        }

        public WinState CreateWinState(GameplayInputArgs inputArgs )
        {
            return new WinState(
                _container.Resolve<IInputService>(),
                _container.Resolve<LevelsProgressionService>(),
                inputArgs,
                _container.Resolve<PlayerDataProvider>(),
                _container.Resolve<SceneSwitcherService>(),
                _container.Resolve<ICoroutinesPerformer>());

        }

        public DefeatState CreateDefeatState()
        {
            return new DefeatState(
                _container.Resolve<IInputService>(),
                _container.Resolve<SceneSwitcherService>(),
                _container.Resolve<ICoroutinesPerformer>());

        }

    }
}
