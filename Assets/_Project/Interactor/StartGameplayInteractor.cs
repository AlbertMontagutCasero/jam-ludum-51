using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class StartGameplayInteractor: Interactor
    {
        public void StartGame()
        {
            var cameraDao = DaoServiceLocator.GetInstance().GetService<CameraDao>();
            var playerDao = DaoServiceLocator.GetInstance().GetService<PlayerDao>();

            var camera = cameraDao.GetCinemachineCamera();
            var player = playerDao.GetPlayer();

            camera.Follow = player.transform;

            var gameDataDao = DaoServiceLocator.GetInstance().GetService<GameDataDao>();
            gameDataDao.clueGiven = 0;
            gameDataDao.racoonsCaught = 0;
            gameDataDao.totalTimeSeconds = 0;
            gameDataDao.remainingSecondsToClue = 10;
            
            GameSignals.OnGameplayStarts?.Invoke(gameDataDao);
        }
    }
}