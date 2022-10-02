namespace LudumDare51.Domain
{
    public class Level
    {
        private readonly LevelId levelId;
        private readonly Map map;
        private LastCompletedData lastCompletedData;
        private int secondsElapsed;

        public Level(LevelId levelId, Map map)
        {
            this.levelId = levelId;
            this.map = map;
            this.lastCompletedData = new LastCompletedData();
        }

        public LevelId GetLevelId()
        {
            return this.levelId;
        }

        public Map GetMap()
        {
            return this.map;
        }

        public int GetSecondsElapsed()
        {
            return this.secondsElapsed;
        }
        
        public void GoToNextSecond()
        {
            this.secondsElapsed++;
        }
    }
}