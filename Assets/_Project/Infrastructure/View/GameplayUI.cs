using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class GameplayUI : MonoBehaviour
    {
        public TextMeshProUGUI remainingSecondsToClueText;
        public TextMeshProUGUI racoonsCaughtText;
        public TextMeshProUGUI racoonsToCatchText;
        public TextMeshProUGUI totalTimeText;
        public TextMeshProUGUI timePenalizationNotificationText;
        public Button catchRacoonButton;
        public GameObject wrapper;

        private List<Tween> tweens;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += OnGameplayStarts;
            GameSignals.OnGameplayFinishes += this.OnGameplayFinishes;

            GameSignals.OnGameplayDataUpdate += this.OnGameplayDataUpdate;
            GameSignals.OnTimePenalization += this.OnTimePenalization;
            catchRacoonButton.onClick.AddListener(this.OnCatchRacoonButtonClick);

            this.tweens = new();
        }

        private void OnGameplayFinishes(GameDataDao obj)
        {
            this.wrapper.SetActive(false);
        }

        private void Start()
        {
            this.wrapper.SetActive(false);
            this.timePenalizationNotificationText.gameObject.SetActive(false);
        }

        private void OnTimePenalization(float penalizationAmount)
        {
            this.RemoveTimePenalizationTweens();

            this.timePenalizationNotificationText.alpha = 0;
            var rectTransformAnchoredPosition = this.timePenalizationNotificationText.rectTransform.anchoredPosition;
            rectTransformAnchoredPosition.y = 0;
            this.timePenalizationNotificationText.rectTransform.anchoredPosition = rectTransformAnchoredPosition;
            this.timePenalizationNotificationText.SetText($"+{penalizationAmount}");
            this.timePenalizationNotificationText.gameObject.SetActive(true);
            var moveTween = this.timePenalizationNotificationText.rectTransform.DOAnchorPosY(100f, 0.7f).SetEase(Ease.OutBack);
            var alphaTween = this.timePenalizationNotificationText.DOFade(1, 0.7f).SetEase(Ease.OutBack);
            alphaTween.OnComplete(() =>
            {
                this.timePenalizationNotificationText.alpha = 0;
                this.timePenalizationNotificationText.gameObject.SetActive(false);
                this.tweens.Remove(alphaTween);
                this.RemoveTimePenalizationTweens();
            });

            this.tweens.Add(moveTween);
            this.tweens.Add(alphaTween);
        }

        private void RemoveTimePenalizationTweens()
        {
            for (var i = this.tweens.Count - 1; i >= 0; i--)
            {
                var currentTween = this.tweens[0];
                this.tweens.Remove(currentTween);
                currentTween.Complete();
            }
        }


        private void OnGameplayStarts(GameDataDao gameDataDao)
        {
            this.wrapper.SetActive(true);
            this.racoonsToCatchText.text = "/" + gameDataDao.gameplayConfiguration.maxRacoonsToCatch.ToString();
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