using UnityEngine;
using Assets._Project.Develop.Runtime.Utilities;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.System;
using Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Features.Sensors
{
    public class BodyContactsDetectingSystem : IInitializableSystem, IUpdatableSystem
    {
        private Buffer<Collider> _contacts;
        private LayerMask _mask;

        private CapsuleCollider _body;

        public void OnInit(Entity entity)
        {
            _contacts = entity.ContactCollidersBuffer;
            _mask = entity.ContactDetectingMask;

            _body = entity.BodyCollider;

        }

        public void OnUpdate(float deltaTime)
        {
            _contacts.Count = Physics.OverlapCapsuleNonAlloc(
                _body.bounds.min,
                _body.bounds.max,
                _body.radius,
                _contacts.Items,
                _mask,
                QueryTriggerInteraction.Ignore);

            RemoveSelfFromCFontaccts();

           
        }

       private void RemoveSelfFromCFontaccts()
       {
            int indexToRemove = -1;

            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts.Items[i] == _body)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove >= 0)
            {
                for (int i = indexToRemove; i < _contacts.Count - 1; i++)
                {
                    _contacts.Items[i] = _contacts.Items[i + 1];
                }

                _contacts.Count--;
            }



        }


    }
}
