using System;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI
{
    public interface IBrain : IDisposable
    {

        void Enable();

        void Disable();

        void Update(float deltaTime);


    }
}
