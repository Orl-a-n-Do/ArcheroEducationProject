using System.Collections.Generic;
using System;

namespace Assets._Project.Develop.Runtime.Utilities.Conditions
{
    public class CompositeCondition : ICompositeCondition
    {
        private List<IСondition> _сonditions = new();
        private Func<bool, bool, bool> _standartLogicOperation;


        public CompositeCondition (Func<bool, bool , bool> standartLogicOperation)
        {
            _standartLogicOperation = standartLogicOperation;
        }

        public CompositeCondition() : this(LogicOperations.And) 
        {

        }

        public ICompositeCondition Add(IСondition condition)
        {
            _сonditions.Add(condition);
            return this;
        }

        public bool Evaluate()
        {
            if (_сonditions.Count == 0)
                return false;

            bool result = _сonditions[0].Evaluate();

            for (int i = 1; i < _сonditions.Count; i++)
            {
                IСondition condition = _сonditions[i];

                result = _standartLogicOperation.Invoke(result, condition.Evaluate());
            }

            return result;
        }

        public ICompositeCondition Remove(IСondition condition)
        {
            _сonditions.Remove(condition);
            return this;
        }
    }
}
