using Assets._Project.Develop.Runtime.Configs.GamePlay.Entities;
using UnityEngine;
using System;






namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Stages
{

    [Serializable]
    public class EnemyItemConfig
    {
        [field: SerializeField] public Vector3 SpawnPosition { get; private set; }
        [field: SerializeField] public EntityConfig EnemyConfig { get; private set; }



    }
}
