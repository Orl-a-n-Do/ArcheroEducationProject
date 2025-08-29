using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcheroEducationProject.Assets._Project.Develop.Runtime.Utilities.LoadingScreen
{
    public interface ILoadingScreen
    {
        bool IsShow { get; }

        void Show();

        void Hide();



    }
}