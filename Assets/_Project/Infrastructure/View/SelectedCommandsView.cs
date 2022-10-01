using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LudumDare51.Infrastructure
{
    public class SelectedCommandsView: MonoBehaviour
    {
        [SerializeField] private Button commandButtonPrefab;
        private int numberOfButtons = 10;
        private List<Button> buttons;

        private void Awake()
        {
            this.buttons = new List<Button>();
        }

        private void Start()
        {
            for (var i = 0; i < this.numberOfButtons; i++)
            {
                this.CreateButton();
            }
        }

        private void CreateButton()
        {
            var button = Instantiate(this.commandButtonPrefab, this.transform);
            var rect = ((RectTransform)button.transform).rect;
            rect.width = this.GetButtonSize();
            var position = new Vector3(0, 0, 0);
            var left = -this.GetWidth() * 0.5f;
            position.x = left;
            position.x += this.GetButtonSize() * 0.5f;
            position.x += this.buttons.Count * this.GetButtonSize();
            button.transform.localPosition = position;
            this.buttons.Add(button);
        }

        private float GetButtonSize()
        {
            return this.GetWidth() / this.numberOfButtons;
        }

        private float GetWidth()
        {
            return ((RectTransform) this.transform).rect.width;
        }
    }
}