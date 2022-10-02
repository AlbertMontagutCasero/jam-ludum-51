using System;
using System.Collections.Generic;
using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Domain;

namespace LudumDare51.Dao
{
    public class DaoLevel : Dao
    {
        private Dictionary<LevelId, Level> levels;
        private readonly CosmeticConfigurationList cosmeticConfigurationList;
        private int levelReached;

        public DaoLevel(CosmeticConfigurationList cosmeticConfigurationList)
        {
            this.levels = new();
            this.cosmeticConfigurationList = cosmeticConfigurationList;
            levelReached = 1;
        }

        public Level GetLevel(LevelId levelId)
        {
            return this.levels[levelId];
        }

        public CosmeticConfiguration GetCosmeticConfiguration(LevelId levelId)
        {
            return this.cosmeticConfigurationList.GetCosmeticConfiguration(levelId);
        }

        public LevelId GetCurrentLevelId()
        {
            return Enum.Parse<LevelId>($"Level{this.levelReached}");
        }

        public void SetLevel(LevelId levelId, Level level)
        {
            this.levels.Add(levelId, level);
        }
    }
}