using System;
using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace Assets._Project.Develop.Runtime.GamePlay.States
{
    public class GamePlayStateMachine : StateMachine<IUpdatableState>
    {
        public GamePlayStateMachine(List<IDisposable> disposables) : base(disposables)
        {

        }

        public GamePlayStateMachine() : base(new List<IDisposable>())
        {


        }

        protected override void UpdateLogic(float deltaTime)
        {
            base.UpdateLogic(deltaTime);

            CurrentState?.Update(deltaTime);
        }




    }
}
