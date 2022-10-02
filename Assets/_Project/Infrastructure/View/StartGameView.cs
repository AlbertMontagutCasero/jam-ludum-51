using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class StartGameView: MonoBehaviour
    {
        private bool isEnabled;

        private void Awake()
        {
            GameSignals.OnGameplayStarts += this.OnGameplayStarts;
            GameSignals.OnGameplayFinishes += this.OnGameplayFinishes;
        }

        private void OnGameplayFinishes(GameDataDao gameDataDao)
        {
            this.isEnabled = false;
        }

        private void OnGameplayStarts(GameDataDao gameDataDao)
        {
            this.isEnabled = true;
        }

        private void Start()
        {
            var startGameplayInteractor = InteractorServiceLocator.GetInstance().GetService<StartGameplayInteractor>();
            startGameplayInteractor.StartGame();
        }

        private void Update()
        {
            if (this.isEnabled)
            {
                var addTimeInteractor = InteractorServiceLocator.GetInstance().GetService<AddTimeInteractor>();
                addTimeInteractor.AddTime(Time.deltaTime);
            }
        }
    }
}