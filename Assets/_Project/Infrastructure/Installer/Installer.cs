using _Project.Infrastructure;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {
        public Player playerPrefab;
        public Camera cameraPrefab;
        public GameObject mapPrefab;
        public GameplayConfiguration gameplayConfiguration;
        
        
        private void Awake()
        {
            // DOMAIN (in this project we are full coupled to unity and we will keep mono and scriptables as domain)
            var player = Instantiate(this.playerPrefab);
            var gameCamera = Instantiate(this.cameraPrefab);
            var map = Instantiate(this.mapPrefab);
            
            // DAO
            DaoServiceLocator.GetInstance().RegisterService(new PlayerDao(player));
            DaoServiceLocator.GetInstance().RegisterService(new CameraDao(gameCamera));
            DaoServiceLocator.GetInstance().RegisterService(new MapDao(map));
            DaoServiceLocator.GetInstance().RegisterService(new GameDataDao(this.gameplayConfiguration));
            
            // INTERACTOR
            InteractorServiceLocator.GetInstance().RegisterService(new StartGameplayInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new AddTimeInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new CatchRacoonInteractor());

            // View
        }
    }
}