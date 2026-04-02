using System.Collections;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Utilities.CourutinesManagement
{
    public interface ICoroutinesPerformer
    {

        Coroutine StartPerform(IEnumerator coroutineFunction);
        void StartPerformer();
        void StopPerform(Coroutine coroutine);

    }
}