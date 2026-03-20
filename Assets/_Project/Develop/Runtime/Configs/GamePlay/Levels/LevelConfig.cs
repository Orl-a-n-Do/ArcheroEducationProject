using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Configs.GamePlay.Stages;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.Configs.GamePlay.Levels
{

    [CreateAssetMenu(menuName ="Configs/Gameplay/Levels/NewLevelConfig", fileName = "LevelConfig")]
    public class LevelConfig: ScriptableObject
    {
        [SerializeField] private List<StageConfig> _stageConfigs;

        public IReadOnlyList<StageConfig> StageConfigs => _stageConfigs;

    }
}
