using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Utilities;
using UnityEngine;




namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors
{
    public class BodyContactsEntitiesFilterSystem : IInitializableSystem, IUpdatableSystem
    {
        private Buffer<Collider> _contacts;
        private Buffer<Entity> _contactsEntities;

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactCollidersBuffer;
            _contactsEntities = entity.ContactEntitiesBuffer;
        }

        public void OnUpdate(float deltaTime)
        {
            _contactsEntities.Count = 0;

            for(int i = 0; i < _contacts.Count; i++)
            {
                Collider collider = _contacts.Items[i];

            }
                
        }
    }
}
