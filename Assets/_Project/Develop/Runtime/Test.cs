using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.AssetsManagment;
using Assets._Project.Develop.Runtime.Utilities.ConfigsManagement;
using Assets._Project.Develop.Runtime.Utilities.CourutinesManagement;
using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{

    private DIContainer _container;

    private void Awake()
    {
        _container = new();

        _container.RegisterAsSingle<ICoroutinesPerformer>(CreateCoroutinesPerformer);

        _container.RegisterAsSingle(CreateConfigsProviderService);

        _container.RegisterAsSingle(CreateResourcesAssetsLoader);


        ICoroutinesPerformer coroutinesPerformer = _container.Resolve<ICoroutinesPerformer>();

        coroutinesPerformer.StartPerform(LoadConfigs());    

    }

    private ConfigsProviderService CreateConfigsProviderService(DIContainer c)
    {
        ResourcesAssetsLoader resourcesAssetsLoader = c.Resolve<ResourcesAssetsLoader>();

        ResourcesConfigLoader resourcesConfigLoader = new ResourcesConfigLoader(resourcesAssetsLoader);

        return new ConfigsProviderService(resourcesConfigLoader);   

    }



    private ResourcesAssetsLoader CreateResourcesAssetsLoader(DIContainer c) => new ResourcesAssetsLoader();

    private CoroutinesPerformer CreateCoroutinesPerformer(DIContainer c)
    {
        ResourcesAssetsLoader _resourcesAssetsLoader = c.Resolve<ResourcesAssetsLoader>();

        CoroutinesPerformer coroutinesPerformerPrefab = _resourcesAssetsLoader
            .Load<CoroutinesPerformer>("Utilities/CoroutinesPerformer");

        return Instantiate(coroutinesPerformerPrefab);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            ConfigsProviderService configsProviderService = _container.Resolve<ConfigsProviderService>();

            TestConfig config = configsProviderService.GetConfig<TestConfig>();
            Debug.Log(config.Damage);
        }

    }

   private IEnumerator LoadConfigs()
    {
        ConfigsProviderService configsProviderService = _container.Resolve<ConfigsProviderService>();

        Debug.Log("StartLoadConfigs");
        yield return configsProviderService.LoadAsync();
        Debug.Log("EndLoadConfigs");
    }

}
