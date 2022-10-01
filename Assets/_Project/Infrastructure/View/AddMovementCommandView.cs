using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class AddMovementCommandView: MonoBehaviour
    {
        [SerializeField] private Button executeAddMovementCommandUseCaseButton;

        private void Awake()
        {
            this.executeAddMovementCommandUseCaseButton.onClick.AddListener(this.OnExecuteAddMovementCommandUseCaseButtonClick);
        }

        private void OnExecuteAddMovementCommandUseCaseButtonClick()
        {
            var addCommandInteractor = InteractorServiceLocator.GetInstance().GetService<AddCommandInteractor>();
            addCommandInteractor.AddCommand();
        }
    }
}