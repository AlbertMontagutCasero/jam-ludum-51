using System;
using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class LevelFactory
    {
        private Dictionary<LevelId, Func<Level>> levelsMapper = new();

        public LevelFactory()
        {
            this.levelsMapper.Add(LevelId.Level01, Level01MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level02, Level02MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level03, Level03MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level04, Level04MapPreset.GetLevel);
            this.levelsMapper.Add(LevelId.Level05, Level05MapPreset.GetLevel);
        }
        
        public Level Create(LevelId levelId)
        {
            return this.levelsMapper[levelId].Invoke();
        }
    }
}