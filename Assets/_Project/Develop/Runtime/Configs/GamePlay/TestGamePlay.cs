using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay
{
    public class TestGamePlay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;
        private BrainsFactory _brainsFactory;


        private Entity _entity;
        private Entity _ghost;


        private bool _isRunning;


        public void Initialize(DIContainer container)
        {
            _container = container;
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
            _brainsFactory = _container.Resolve<BrainsFactory>();

        }


        public void Run()
        {
            _entity = _entitiesFactory.CreateHero(Vector3.zero);
            _ghost = _entitiesFactory.CreateGhost(Vector3.zero + Vector3.forward * 5);

            _isRunning = true;
        }


        private void Update()
        {
            if (_isRunning == false)
                return;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                _entity.TakeDamageRequest.Invoke(50);
                //Debug.Log("Текущий уровень здоровья :" + _entity.CurrentHealth.Value.ToString());
            }


            if (Input.GetKeyDown(KeyCode.R))
            {
                _entity.StartAttackRequest.Invoke();
                //Debug.Log("Текущий уровень здоровья :" + _entity.CurrentHealth.Value.ToString());
            }

            if (Input.GetKeyDown(KeyCode.I))
                _brainsFactory.CreateGhostBrain(_ghost);



            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

            _entity.MoveDirection.Value = input;
            _entity.RotationDirection.Value = input;
        }

    }
}
