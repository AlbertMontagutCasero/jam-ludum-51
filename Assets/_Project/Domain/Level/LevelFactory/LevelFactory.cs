using System;
using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class LevelFactory
    {
        private Dictionary<LevelId, Func<Level>> levelsMapper = new();

        public LevelFactory()
        {
            this.levelsMapper.Add(LevelId.Level1, LevelTESTMapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level2, Level02MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level3, Level03MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level4, Level04MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level5, Level05MapPreset.GetLevel);
        }
        
        public Level Create(LevelId levelId)
        {
            return this.levelsMapper[levelId].Invoke();
        }
    }
}