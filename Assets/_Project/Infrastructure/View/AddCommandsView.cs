using System.Collections.Generic;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class AddCommandsView: MonoBehaviour
    {
        private List<AddCommandButtonView> addCommandButtonViews = new();

        [SerializeField]
        private AddCommandButtonView addCommandButtonViewPrefab;
        
        private void Start()
        {
            var getCommandConfigurationInteractor = InteractorServiceLocator.GetInstance().GetService<GetCommandConfigurationInteractor>();
            var commandConfiguration = getCommandConfigurationInteractor.GetCommandsConfiguration();

            for (var i = 0; i < commandConfiguration.Count; i++)
            {
                var currentCommandConfiguration = commandConfiguration[i];
                var addCommandButtonView = Instantiate(this.addCommandButtonViewPrefab, this.transform);
                ((RectTransform)addCommandButtonView.transform).localPosition = Vector3.right * i * this.GetButtonSize();

                addCommandButtonView.SetConfiguration(currentCommandConfiguration);
                this.addCommandButtonViews.Add(addCommandButtonView);
            }
        }

        private float GetButtonSize()
        {
            return 96;
        }
    }
}