using System;
using LudumDare51.Interactor;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class PlayButtonView: MonoBehaviour
    {
        [SerializeField] private Button playButton;

        private void Awake()
        {
            this.playButton.onClick.AddListener(this.OnPlayButtonClick);
        }

        private void OnPlayButtonClick()
        {
            var playInteractor = InteractorServiceLocator.GetInstance().GetService<PlayInteractor>();
            playInteractor.Execute();
        }
    }
}