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
                var buttonRectTransform = ((RectTransform) addCommandButtonView.transform); 
                var buttonPosition = Vector3.zero;
                buttonPosition.x = -(this.GetWidth() * 0.5f);
                buttonPosition.x += i * this.GetOffsetBetweenButtons();
                buttonRectTransform.localPosition = buttonPosition;

                addCommandButtonView.SetConfiguration(currentCommandConfiguration);
                this.addCommandButtonViews.Add(addCommandButtonView);
            }
        }

        private float GetWidth()
        {
            return ((RectTransform)this.transform).rect.width;
        }

        private float GetButtonSize()
        {
            return 96;
        }
        
        private float GetOffsetBetweenButtons()
        {
            var offsetBetweenButtons = 16;
            return this.GetButtonSize() + offsetBetweenButtons;
        }
    }
}