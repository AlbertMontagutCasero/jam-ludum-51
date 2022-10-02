using LudumDare51.Dao;
using UnityEngine;

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
                Debug.Log("SHOULD GIVE CLUE");
                GameSignals.OnCheckClue?.Invoke(gameDataDao.clueGiven);
                gameDataDao.shouldGiveAnotherClue = false;
            }
            

            GameSignals.OnGameplayDataUpdate.Invoke(gameDataDao);
        }
    }
}