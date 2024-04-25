using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts {
    [RequireComponent(typeof(Slider))]
    public class ResettableSlider : MonoBehaviour {
        [SerializeField] private Button resetButton;
        [SerializeField] private float defaultValue = 1;
        private Slider _slider;

        private void Start() {
            _slider = GetComponent<Slider>();
            _slider.onValueChanged.AddListener(value => {
                resetButton.interactable = Math.Abs(value - defaultValue) > 0.0001f;
            });
            resetButton.interactable = Math.Abs(_slider.value - defaultValue) > 0.0001f;
        
            resetButton.onClick.AddListener(() => _slider.value = defaultValue);
        }
    }
}
