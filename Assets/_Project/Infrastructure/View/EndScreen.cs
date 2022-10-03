using System.Globalization;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class EndScreen: MonoBehaviour
    {
        public GameObject wrapper;
        public Button retryButton;
        public TextMeshProUGUI totalTimeSecondsText;
        
        
        private void Awake()
        {
            GameSignals.OnGameplayFinishes += this.OnGameplayFinishes;
            this.retryButton.onClick.AddListener(this.OnReTryButtonClick);
        }

        private void Start()
        {
            this.wrapper.SetActive(false);
        }

        private void OnReTryButtonClick()
        {
            this.wrapper.SetActive(false);
            var startGameplayInteractor = InteractorServiceLocator.GetInstance().GetService<StartGameplayInteractor>();
            startGameplayInteractor.StartGame();
        }

        private void OnGameplayFinishes(GameDataDao gameDataDao)
        {
            this.wrapper.SetActive(true);
            
            var totalTimeSeconds = gameDataDao.totalTimeSeconds;
            totalTimeSecondsText.SetText(GetAs2Decimals(totalTimeSeconds).ToString(CultureInfo.InvariantCulture));
            
            // ABOUT US
        }
        
        private float GetAs2Decimals(float time)
        {
            int removedDecimals = (int)(time * 100);
            return (float)(removedDecimals * 0.01);
        }
    }
}