using System;
using System.Collections.Generic;
using LudumDare51.Domain;
using UnityEngine;

namespace _Project.Infrastructure.UnityConfiguration
{
    [CreateAssetMenu(fileName = "CosmeticConfiguration", menuName = "Configuration/Cosmetic Configuration List")]
    public class CosmeticConfigurationList: ScriptableObject
    {
        [SerializeField] private List<CosmeticConfiguration> cosmeticConfigurations;

        public CosmeticConfiguration GetCosmeticConfiguration(LevelId levelId)
        {
            return this.cosmeticConfigurations.Find(configuration => configuration.levelId == levelId);
        }
    }

    [Serializable]
    public class CosmeticConfiguration
    {
        public LevelId levelId;
        public List<CosmeticItemPreset> cosmeticItemPresets;
    }
    
    
    [Serializable]
    public class CosmeticItemPreset
    {
        public CosmeticId cosmeticId;
        public int secondToActivate = 0;
    }
}