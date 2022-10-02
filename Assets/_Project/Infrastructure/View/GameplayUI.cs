using LudumDare51.Interactor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class GameplayUI: MonoBehaviour
    {
        public TextMeshProUGUI remainingTriesText;
        public TextMeshProUGUI remainingSeconds;
        public TextMeshProUGUI racoonsCaught;
        public Button catchRacoonButton;

        private void Awake()
        {
            GameSignals.OnGameplayDataUpdate += this.OnGameplayDataUpdate;
            catchRacoonButton.onClick.AddListener(this.OnCatchRacoonButtonClick);
        }

        private void OnCatchRacoonButtonClick()
        {
            Debug.Log("RACOON CATCH BUTTON CLICKED");
        }

        private void OnGameplayDataUpdate(GameplayDataResponse gameplayDataResponse)
        {
            this.remainingTriesText.text = gameplayDataResponse.remainingTry.ToString();
            this.remainingSeconds.text = Mathf.CeilToInt(gameplayDataResponse.remainingSeconds).ToString();
            this.racoonsCaught.text = gameplayDataResponse.racoonsCaught.ToString();
        }
    }
}