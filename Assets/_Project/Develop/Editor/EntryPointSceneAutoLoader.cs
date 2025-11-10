using UnityEditor;
using UnityEditor.SceneManagement;



[InitializeOnLoad] //для того чтобы кода выпеолнялся вместе с запуском игры в редакторе;
public static class EntryPointSceneAutoLoader 
{
   

    static EntryPointSceneAutoLoader()// при нажатии на play выполниться следующее;
    {
        if(EditorBuildSettings.scenes.Length == 0)
            return;

        EditorSceneManager.playModeStartScene = AssetDatabase
            .LoadAssetAtPath<SceneAsset>(EditorBuildSettings.scenes[0].path);



    }

    
}
