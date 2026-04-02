using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.InputFeature;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace Assets._Project.Develop.Runtime.GamePlay.States
{
    public abstract class EndGameState: State
    {
        private readonly IInputService _inputService;

        protected EndGameState(IInputService inputService)
        {

            _inputService = inputService;

        }

        public override void Enter()
        {
            base.Enter();   
            _inputService.IsEnabled = false;
        }

        public override void Exit()
        {
            base.Exit();    
            _inputService.IsEnabled = true;
        }

    }
}
