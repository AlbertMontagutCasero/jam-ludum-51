namespace LudumDare51.Domain
{
    public class Level
    {
        private readonly LevelId levelId;
        private readonly Map map;
        private LastCompletedData lastCompletedData;

        public Level(LevelId levelId, Map map)
        {
            this.levelId = levelId;
            this.map = map;
            this.lastCompletedData = new LastCompletedData();
        }

        public Map GetMap()
        {
            return this.map;
        }
    }
}