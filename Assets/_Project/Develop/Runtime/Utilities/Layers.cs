using UnityEngine;

namespace Assets._Project.Develop.Runtime.Utilities
{
    public class Layers
    {
        public static readonly int Characters = LayerMask.NameToLayer("Character");
        public static readonly LayerMask CharactersMask = 1 <<  Characters; 

    }
}
