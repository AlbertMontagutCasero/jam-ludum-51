using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Domain;
using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class AddCommandButtonView: MonoBehaviour
    {
        [SerializeField] private Button executeAddMovementCommandUseCaseButton;
        private CommandConfiguration commandConfiguration;

        private void Awake()
        {
            this.executeAddMovementCommandUseCaseButton.onClick.AddListener(this.OnExecuteAddMovementCommandUseCaseButtonClick);
        }

        public void SetConfiguration(CommandConfiguration commandConfiguration)
        {
            this.commandConfiguration = commandConfiguration;
            this.executeAddMovementCommandUseCaseButton.image.sprite = commandConfiguration.GetTexture();
        }
        
        private void OnExecuteAddMovementCommandUseCaseButtonClick()
        {
            var addCommandInteractor = InteractorServiceLocator.GetInstance().GetService<AddCommandInteractor>();
            addCommandInteractor.AddCommand(this.GetCommandId());
        }

        private CommandId GetCommandId()
        {
            return this.commandConfiguration.GetCommandId();
        }
    }
}