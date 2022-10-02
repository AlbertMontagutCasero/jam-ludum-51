using LudumDare51.Infrastructure;

namespace LudumDare51.Dao
{
    public class GameDataDao: Dao
    {
        public int remainingTries;
        public float remainingSecondsToClue;
        public float totalTimeSeconds;
        public int racoonsCaught;
        public GameplayConfiguration gameplayConfiguration;

        public GameDataDao(GameplayConfiguration gameplayConfiguration)
        {
            this.gameplayConfiguration = gameplayConfiguration;
        }

        public void AddTime(float elapsedSeconds)
        {
            this.totalTimeSeconds += elapsedSeconds;
            this.remainingSecondsToClue -= elapsedSeconds;

            if (this.remainingSecondsToClue < 0)
            {
                this.remainingSecondsToClue += 10;
            }
        }

        public void AddTimePenalization()
        {
            this.totalTimeSeconds += this.gameplayConfiguration.timePenalizationByMissingCatch;
        }
    }
}