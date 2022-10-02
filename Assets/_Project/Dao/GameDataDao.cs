using LudumDare51.Infrastructure;

namespace LudumDare51.Dao
{
    public class GameDataDao: Dao
    {
        public float remainingSecondsToClue;
        public float totalTimeSeconds;
        public int racoonsCaught;
        public GameplayConfiguration gameplayConfiguration;

        public bool shouldGiveAnotherClue = true;
        public int clueGiven = 0;

        public GameDataDao(GameplayConfiguration gameplayConfiguration)
        {
            this.gameplayConfiguration = gameplayConfiguration;
            this.remainingSecondsToClue = 10;
        }

        public void AddTime(float elapsedSeconds)
        {
            this.totalTimeSeconds += elapsedSeconds;
            this.remainingSecondsToClue -= elapsedSeconds;

            if (this.remainingSecondsToClue < 0)
            {
                this.remainingSecondsToClue += 10;
                this.clueGiven++;
                this.shouldGiveAnotherClue = true;
            }
        }

        public void AddTimePenalization()
        {
            this.totalTimeSeconds += this.gameplayConfiguration.timePenalizationByMissingCatch;
        }
    }
}