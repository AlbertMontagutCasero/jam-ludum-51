using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class AddTimeInteractor: Interactor
    {
        public void AddTime(float delta)
        {
            var gameDataDao = DaoServiceLocator.GetInstance().GetService<GameDataDao>();

            var elapsedSeconds = delta;
            gameDataDao.AddTime(elapsedSeconds);
            if (gameDataDao.shouldGiveAnotherClue)
            {
                GameSignals.OnCheckClue?.Invoke(gameDataDao.clueGiven);
                gameDataDao.shouldGiveAnotherClue = false;
            }

            GameSignals.OnGameplayDataUpdate.Invoke(gameDataDao);
        }
    }
}