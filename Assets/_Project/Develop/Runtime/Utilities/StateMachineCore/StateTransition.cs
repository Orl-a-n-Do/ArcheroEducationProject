using Assets._Project.Develop.Runtime.Utilities.Conditions;

namespace Assets._Project.Develop.Runtime.Utilities.StateMachineCore
{
    public class StateTransition<TState> where TState : class, IState
    {
        public StateTransition(StateNode<TState> toState, IСondition condition)
        {
            ToState = toState;
            Condition = condition;
        }

        public StateNode<TState> ToState {  get; }
        public IСondition Condition { get; }


    }
}
