using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Utilities.ConfigsManagement
{
    public class ResourcesConfigLoader : IConfigsLoader
    {
        private readonly ResourcesAssetsLoader _resources;
        private readonly Dictionary<Type, string> _configsResourcesPaths = new()
        {
       

        };

        public ResourcesConfigLoader(ResourcesAssetsLoader resources)
        {
            _resources = resources;
        }


        public IEnumerator LoadAsync(Action<Dictionary<Type, object>> onConfigsLoaded)
        {
            Dictionary<Type, object> loadedConfigs = new();

            foreach (KeyValuePair<Type, string> configResorcesPath in _configsResourcesPaths)
            {
                ScriptableObject config = _resources.Load<ScriptableObject>(configResorcesPath.Value);
                loadedConfigs.Add(configResorcesPath.Key, config);
                yield return null;
            }

            onConfigsLoaded?.Invoke(loadedConfigs);
        }
    }
}