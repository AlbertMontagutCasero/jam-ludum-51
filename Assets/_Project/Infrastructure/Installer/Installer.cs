using System;
using _Project.Infrastructure;
using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {
        public Player playerPrefab;
        public Camera cameraPrefab;
        
        private void Awake()
        {
            // DOMAIN (in this project we are full coupled to unity and we will keep mono and scriptables as domain)
            var player = Instantiate(this.playerPrefab);
            var gameCamera = Instantiate(this.cameraPrefab);


            // DAO
            DaoServiceLocator.GetInstance().RegisterService(new PlayerDao(player));
            DaoServiceLocator.GetInstance().RegisterService(new CameraDao(gameCamera));
            

            // INTERACTOR
            InteractorServiceLocator.GetInstance().RegisterService(new StartGameplayInteractor());

            // View
            new GameObject("StartGameView").AddComponent<StartGameView>();
        }
    }
}