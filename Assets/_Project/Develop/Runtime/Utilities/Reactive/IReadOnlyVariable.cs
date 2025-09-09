using System;
namespace Assets._Project.Develop.Runtime.Utilities.Reactive
{
    public interface IReadOnlyVariable<T>
    {
        T Value { get; set; }

        IDisposable Subscribe(Action<T, T> action);

    }
}

