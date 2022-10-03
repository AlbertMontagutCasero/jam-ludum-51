using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class Clue : MonoBehaviour
    {
        public int iterationToShow = 0;
        public GameObject clueGameObject;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += OnGameplayStarts;
            GameSignals.OnGameplayFinishes += OnGameplayFinishes;
            GameSignals.OnCheckClue += this.OnCheckClue;
        }

        private void OnGameplayFinishes(GameDataDao obj)
        {
            this.clueGameObject.SetActive(false);
        }

        private void OnGameplayStarts(GameDataDao obj)
        {
            if (this.iterationToShow == 0)
            {
                this.ShowClue();
            }
        }

        private void OnDestroy()
        {
            GameSignals.OnCheckClue -= this.OnCheckClue;
        }

        private void Start()
        {
            this.clueGameObject.SetActive(false);

            if (this.iterationToShow == 0)
            {
                this.ShowClue();
            }
        }

        private void ShowClue()
        {
            this.clueGameObject.SetActive(true);
        }

        private void OnCheckClue(int clueToShow)
        {
            if (clueToShow == this.iterationToShow)
            {
                this.ShowClue();       
            }
        }
    }
}