using LudumDare51.Interactor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class Example1View: MonoBehaviour
    {
        [SerializeField]
        private Button executeUseCaseButton;
        
        [SerializeField]
        private TextMeshProUGUI executeUseCaseButtonText;

        private bool isCreated = false;
        
        private void Start()
        {
            GameSignals.OnClick += this.OnBusinessThingyDone;
            GameSignals.OnCreated += this.OnCreated;
            this.executeUseCaseButton.onClick.AddListener(this.OnExecuteUseCaseButton);
            
            this.SetTextAsInteractToCreate();
        }

        private void OnCreated()
        {
            this.isCreated = true;
            this.SetTextAsInteractToDoSomething();
        }

        private void OnExecuteUseCaseButton()
        {
            var example1Interactor = InteractorServiceLocator.GetInstance().GetService<Example1Interactor>();

            if (!this.isCreated)
            {
                example1Interactor.InteractWithSystemToCreate();
            }
            else
            {
                example1Interactor.InteractWithSystemToDoSomething();
            }
        }


        private void OnBusinessThingyDone(string thingyDone)
        {
            Debug.Log($"Business thingy done {thingyDone}");
        }
        
        private void SetTextAsInteractToCreate()
        {
            this.executeUseCaseButtonText.text = "Execute Creation";
        }
        
        
        private void SetTextAsInteractToDoSomething()
        {
            this.executeUseCaseButtonText.text = "Execute Do Something";
        }
    }
}