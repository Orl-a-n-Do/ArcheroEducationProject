using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

namespace Assets._Project.Develop.Runtime.Utilities.ConfigsManagement
{
    public class ConfigsProviderService
    {
        private readonly Dictionary<Type, object> _configs = new();
        private readonly IConfigsLoader[] _loaders;

        public ConfigsProviderService(params IConfigsLoader[] loaders)
        {
            _loaders = loaders;

        }

        public IEnumerator LoadAsync()
        {
            _configs.Clear();

            foreach (IConfigsLoader loader in _loaders)
                yield return loader.LoadAsync(loadedConfigs => _configs.AddRange(loadedConfigs));





        }


        public T GetConfig<T>() where T : class
        {

            if (_configs.ContainsKey(typeof(T)) == false)
                throw new InvalidOperationException($"Config {typeof(T)} not found");

            return (T)_configs[typeof(T)];

        }



    }
}