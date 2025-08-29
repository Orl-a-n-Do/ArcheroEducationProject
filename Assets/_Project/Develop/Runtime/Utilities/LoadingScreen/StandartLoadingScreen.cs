using UnityEngine;

namespace ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.LoadingScreen
{
    public class StandartLoadingScreen : MonoBehaviour, ILoadingScreen
    {
        public bool IsShow => gameObject.activeSelf;

        public void Awake()
        {
            Hide();
            DontDestroyOnLoad(this);
        }


        public void Hide() => gameObject.SetActive(false);
        public void Show() => gameObject.SetActive(true);
        
                          
    }
}