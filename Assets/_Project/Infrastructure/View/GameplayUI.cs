using System.Globalization;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class GameplayUI : MonoBehaviour
    {
        public TextMeshProUGUI remainingTriesText;
        public TextMeshProUGUI remainingSecondsToClueText;
        public TextMeshProUGUI racoonsCaughtText;
        public TextMeshProUGUI racoonsToCatchText;
        public TextMeshProUGUI totalTimeText;
        public Button catchRacoonButton;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += OnGameplayStarts;

            GameSignals.OnGameplayDataUpdate += this.OnGameplayDataUpdate;
            GameSignals.OnTimePenalization += this.OnTimePenalization;
            catchRacoonButton.onClick.AddListener(this.OnCatchRacoonButtonClick);
        }

        private void OnTimePenalization(float penalizationAmount)
        {
            Debug.Log($"TIME PENALIZATION {penalizationAmount}");
        }


        private void OnGameplayStarts(GameDataDao gameDataDao)
        {
            this.racoonsToCatchText.text = gameDataDao.gameplayConfiguration.maxRacoonsToCatch.ToString();
            this.UpdateData(gameDataDao);
        }

        private void OnCatchRacoonButtonClick()
        {
            var catchRacoonInteractor = InteractorServiceLocator.GetInstance().GetService<CatchRacoonInteractor>();
            catchRacoonInteractor.Catch();
        }

        private void OnGameplayDataUpdate(GameDataDao gameplayDataResponse)
        {
            this.UpdateData(gameplayDataResponse);
        }

        private void UpdateData(GameDataDao gameplayDataResponse)
        {
            this.remainingTriesText.text = gameplayDataResponse.remainingTries.ToString();
            this.remainingSecondsToClueText.text =
                Mathf.CeilToInt(gameplayDataResponse.remainingSecondsToClue).ToString();
            this.racoonsCaughtText.text = gameplayDataResponse.racoonsCaught.ToString();
            var totalTime = this.GetAs2Decimals(gameplayDataResponse.totalTimeSeconds)
                .ToString(CultureInfo.InvariantCulture);
            this.totalTimeText.text = totalTime;
        }

        private float GetAs2Decimals(float time)
        {
            int removedDecimals = (int)(time * 100);
            return (float)(removedDecimals * 0.01);
        }
    }
}