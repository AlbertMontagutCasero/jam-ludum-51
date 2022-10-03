using System;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class TutorialScreen: MonoBehaviour
    {
        public GameObject wrapper;

        private void Awake()
        {
            // open after menu
            // launch start interactor 
        }

        private void Start()
        {
            this.wrapper.SetActive(false);
        }
    }
}