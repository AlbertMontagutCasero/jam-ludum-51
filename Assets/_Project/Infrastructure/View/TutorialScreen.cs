using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class TutorialScreen : MonoBehaviour
    {
        public GameObject wrapper;
        public Button continueButton;

        private void Awake()
        {
            GameSignals.OnStartTutorial += OnStartTutorial;
            GameSignals.OnGameplayStarts += OnGameplayStarts;

            this.continueButton.onClick.AddListener(this.OnContinueButton);
        }

        private void OnGameplayStarts(GameDataDao obj)
        {
            this.wrapper.SetActive(false);
        }

        private void OnStartTutorial()
        {
            this.wrapper.SetActive(true);
        }

        private void OnContinueButton()
        {
            var startGameplayInteractor = InteractorServiceLocator.GetInstance().GetService<StartGameplayInteractor>();
            startGameplayInteractor.StartGame();
        }

        private void Start()
        {
            this.wrapper.SetActive(false);
        }
    }
}