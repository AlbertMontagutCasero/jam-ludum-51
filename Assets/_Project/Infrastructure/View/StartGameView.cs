using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class StartGameView: MonoBehaviour
    {
        private void Start()
        {
            var startGameplayInteractor = InteractorServiceLocator.GetInstance().GetService<StartGameplayInteractor>();
            startGameplayInteractor.StartGame();
        }
    }
}