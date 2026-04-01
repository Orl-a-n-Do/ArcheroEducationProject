using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities;
using Assets._Project.Develop.Runtime.Utilities.Reactive;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.StagesFeatures
{
    public class ProperationTriggerService
    {
        private ReactiveVariable<bool> _hasMainHeroContact = new();

        private EntitiesFactory _entitiesFactory;
        private EntitiesLifeContext _entitiesLifeContext;

        private Entity _nextStageTrigger;
        private Buffer<Entity> _nextStageTriggerContacts;

        public ProperationTriggerService(
            EntitiesFactory entitiesFactory, 
            EntitiesLifeContext entitiesLifeContext)
        {
            _entitiesFactory = entitiesFactory;
            _entitiesLifeContext = entitiesLifeContext;
        }
    }
}
