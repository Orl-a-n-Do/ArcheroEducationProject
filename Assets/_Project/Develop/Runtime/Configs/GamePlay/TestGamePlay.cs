using System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Entities;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.AI.States;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Enemies;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.MainHero;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Features.StagesFeatures;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Stages;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;


namespace Assets._Project.Develop.Runtime.Configs.GamePlay
{
    public class TestGamePlay : MonoBehaviour
    {
        private DIContainer _container;
        private EntitiesFactory _entitiesFactory;
        private BrainsFactory _brainsFactory;

        [SerializeField] private HeroConfig _heroConfig;

        [SerializeField] private StageConfig _stageConfig;

        private StagesFactory _stagesFactory;
        private IStage _stage;
        

        private MainHeroFactory _mainHeroFactory;
        private EnemiesFactory _enemiesFactory;


        private Entity _entity;
        private Entity _ghost;


        private bool _isRunning;


        public void Initialize(DIContainer container)
        {
            _container = container;
            _entitiesFactory = _container.Resolve<EntitiesFactory>();
            _brainsFactory = _container.Resolve<BrainsFactory>();

            _mainHeroFactory = _container.Resolve<MainHeroFactory>();
            _enemiesFactory = _container.Resolve<EnemiesFactory>();

            _stagesFactory = _container.Resolve<StagesFactory>();   
        }


        public void Run()
        {
           
            _entity = _mainHeroFactory.Create(Vector3.zero);

            _stage = _stagesFactory.Create(_stageConfig);
            _stage.Completed.Subscribe(OnCompleted);
            _stage.Start();

            _isRunning = true;
        }

        private void OnCompleted()
        {
           Debug.Log("Победа");
            _stage.Cleanup();
        }

        private void Update()
        {
            if (_isRunning == false)
                return;

            _stage.Update(Time.deltaTime);

        }

    }
}
