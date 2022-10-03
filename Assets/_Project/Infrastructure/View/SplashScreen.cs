using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class SplashScreen: MonoBehaviour
    {
        public Button playButton;
        public GameObject wrapper;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += this.OnGameplayStarts;
        }

        private void OnGameplayStarts(GameDataDao obj)
        {
            this.wrapper.SetActive(false);
        }

        private void Start()
        {
            this.playButton.onClick.AddListener(this.OnPlayButtonClick);
        }

        private void OnPlayButtonClick()
        {
            var startGameplayInteractor = InteractorServiceLocator.GetInstance().GetService<StartGameplayInteractor>();
            startGameplayInteractor.StartGame();
        }
    }
}