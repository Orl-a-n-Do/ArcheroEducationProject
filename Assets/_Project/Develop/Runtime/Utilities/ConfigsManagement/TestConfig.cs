using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Utilities.ConfigsManagement
{
    [CreateAssetMenu(fileName = "Test", menuName = "TestConfig")]
    public class TestConfig : ScriptableObject
    {

        [field: SerializeField] public int Damage { get; private set; }




    }
}