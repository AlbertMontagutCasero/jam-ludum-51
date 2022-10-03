using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class CatchRacoonInteractor: Interactor
    {
        private bool isInRange;

        public void Catch()
        {
            var gameDataDao = DaoServiceLocator.GetInstance().GetService<GameDataDao>();
            if (this.isInRange)
            {
                gameDataDao.racoonsCaught++;
                GameSignals.OnRacoonCaught?.Invoke();

                if (gameDataDao.IsGameCompleted())
                {
                    GameSignals.OnGameplayFinishes?.Invoke(gameDataDao);
                }
            }
            else
            {
                gameDataDao.AddTimePenalization();
                GameSignals.OnTimePenalization?.Invoke(gameDataDao.gameplayConfiguration.timePenalizationByMissingCatch);
            }
            GameSignals.OnGameplayDataUpdate(gameDataDao);
        }

        public void SetAsInsideRacoonRange()
        {
            this.isInRange = true;
        }

        public void SetAsOutsideRacoonRange()
        {
            this.isInRange = false;
        }
    }
}