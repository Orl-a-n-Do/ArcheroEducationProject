using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.LifeCircle
{
    public class SelfReleaseSystem : IInitializableSystem, IUpdatableSystem

    {

        private readonly EntitiesLifeContext _entitiesLifeContext;


        private Entity _entity;

        private ICompositeCondition _mustSelfRelease;

      

        public SelfReleaseSystem(EntitiesLifeContext entitiesLifeContext)
        {
            _entitiesLifeContext = entitiesLifeContext;
        }

        public void OnInit(Entity entity)
        {
            _entity = entity;
            _mustSelfRelease = entity.MustSelfRelease;
        }

        public void OnUpdate(float deltaTime)
        {
            if(_mustSelfRelease.Evaluate() )
                _entitiesLifeContext.Release(_entity);

        }
    }
}
