using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    private ResourcesAssetsLoader _resourcesAssetsLoader;
    private ICoroutinesPerformer _coroutinesPerformer;

    private void Awake()
    {
        _resourcesAssetsLoader = CreateResourcesAssetsLoader();

        _coroutinesPerformer = CreateCoroutinesPerformer();
    }

    private ResourcesAssetsLoader CreateResourcesAssetsLoader() => new ResourcesAssetsLoader();

    private CoroutinesPerformer CreateCoroutinesPerformer()
    {
        CoroutinesPerformer coroutinesPerformerPrefab = _resourcesAssetsLoader
            .Load<CoroutinesPerformer>("Utilities/CoroutinesPerformer");

        return Instantiate(coroutinesPerformerPrefab);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            _coroutinesPerformer.StartPerform(TestCoroutine());
    }

   private IEnumerator TestCoroutine()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(1f);
        Debug.Log("End");
    }

}
