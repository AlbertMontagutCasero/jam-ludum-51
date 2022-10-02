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
            GameSignals.OnCheckClue += this.OnCheckClue;
        }

        private void OnDestroy()
        {
            GameSignals.OnCheckClue -= this.OnCheckClue;
        }

        private void Start()
        {
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