using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using Unity.VisualScripting;

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
