using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MovementFeature;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay
{
    public class TestGamePlay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;



        private bool _isRunning;


        public void Initialize(DIContainer container)
        {
            _container = container;
            _entitiesFactory = _container.Resolve<EntitiesFactory>();

        }


        public void Run()
        {
            Entity entity = _entitiesFactory.CreateTestEntity();


            Debug.Log("Направление движения:" + entity.GetComponent<MoveDirection>().Value.Value.ToString());
            Debug.Log("Скорость движения:" + entity.GetComponent<MoveSpeed>().Value.Value.ToString());


            _isRunning = true;
        }


        private void Update()
        {
            if (_isRunning == false)
                return;


        }

    }
}
