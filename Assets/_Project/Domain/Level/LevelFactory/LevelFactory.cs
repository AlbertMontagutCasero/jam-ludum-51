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
        }
        
        public Level Create(LevelId levelId)
        {
            return this.levelsMapper[levelId].Invoke();
        }
    }
}