using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class Racoon: MonoBehaviour
    {
        private bool isInside;
        public BoxCollider2D boxCollider2D;

        private void Awake()
        {
            GameSignals.OnRacoonCaught += this.OnRacoonCaught;
            GameSignals.OnGameplayStarts += OnGameplayStarts;
        }

        private void OnGameplayStarts(GameDataDao obj)
        {
            this.boxCollider2D.enabled = true;
        }

        private void Start()
        {
            this.boxCollider2D.enabled = false;
        }

        private void OnDestroy()
        {
            GameSignals.OnRacoonCaught -= this.OnRacoonCaught;
        }

        private void OnRacoonCaught()
        {
            if (this.isInside)
            {
                this.boxCollider2D.enabled = false;
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            this.isInside = true;

            var catchRacoonInteractor = InteractorServiceLocator.GetInstance().GetService<CatchRacoonInteractor>();
            catchRacoonInteractor.SetAsInsideRacoonRange();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            this.isInside = false;
            
            
            var catchRacoonInteractor = InteractorServiceLocator.GetInstance().GetService<CatchRacoonInteractor>();
            catchRacoonInteractor.SetAsOutsideRacoonRange();
        }
    }
}