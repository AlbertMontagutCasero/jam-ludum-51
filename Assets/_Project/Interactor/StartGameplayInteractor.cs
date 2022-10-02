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
            GameSignals.OnGameplayStarts?.Invoke(gameDataDao);
        }
    }
}