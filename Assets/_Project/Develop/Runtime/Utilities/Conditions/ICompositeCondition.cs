namespace Assets._Project.Develop.Runtime.Utilities.Conditions
{
    public interface ICompositeCondition : IСondition
    {
        ICompositeCondition Add(IСondition condition);
        ICompositeCondition Remove(IСondition condition);
    }
}
