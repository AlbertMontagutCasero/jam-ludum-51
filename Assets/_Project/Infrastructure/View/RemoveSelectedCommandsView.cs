using System;
using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class RemoveSelectedCommandsView: MonoBehaviour
    {
        [SerializeField] private Button removeSelectedCommandsButton;


        private void Awake()
        {
            this.removeSelectedCommandsButton.onClick.AddListener(this.OnRemoveSelectedCommandsButtonClick);
        }

        private void OnRemoveSelectedCommandsButtonClick()
        {
            var removeSelectedCommandsInteractor = InteractorServiceLocator.GetInstance().GetService<RemoveSelectedCommandsInteractor>();
            removeSelectedCommandsInteractor.RemoveAllSelectedCommands();
        }
    }
}