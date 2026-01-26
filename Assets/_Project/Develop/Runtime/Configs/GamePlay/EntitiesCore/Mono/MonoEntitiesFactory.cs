using System;
using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.EntitiesCore.Mono
{
    public class MonoEntitiesFactory : IInitializable, IDisposable
    {
        private readonly ResourcesAssetsLoader _resourses;

        private readonly EntitiesLifeContext _entitiesLifeContext;

        private readonly CollidersRegistryService _colidersRegistryService;



        private readonly Dictionary<Entity, MonoEntity> _entityToMono = new();

        public MonoEntitiesFactory(
            ResourcesAssetsLoader resourses,
            EntitiesLifeContext entitiesLifeContext,
            CollidersRegistryService colidersRegistryService)
        {
            _resourses = resourses;
            _entitiesLifeContext = entitiesLifeContext;
            _colidersRegistryService = colidersRegistryService;
        }

        public MonoEntity Create(Entity entity, Vector3 position, string path)
        {
            MonoEntity prefab = _resourses.Load<MonoEntity>(path);

            MonoEntity viewInstance = Object.Instantiate(prefab, position, Quaternion.identity, null);


            viewInstance.Initialize(_colidersRegistryService);

            viewInstance.Link(entity);

            _entityToMono.Add(entity, viewInstance);

            return viewInstance;

        }
        public void Initialize()
        {
            _entitiesLifeContext.Released += OnEntityRelesased;
        }


        public void Dispose()
        {
            _entitiesLifeContext.Released -= OnEntityRelesased;

            foreach(Entity entity in _entityToMono.Keys)
                    CleanupFor(entity);

            _entityToMono.Clear();
        }

        private void OnEntityRelesased(Entity entity)
        {

            CleanupFor(entity);

            _entityToMono.Remove(entity);
        }

        private void CleanupFor(Entity entity)
        {
            MonoEntity monoEntity = _entityToMono[entity];
            monoEntity.Cleanup(entity);
            Object.Destroy(monoEntity.gameObject);
        }



    }
}
