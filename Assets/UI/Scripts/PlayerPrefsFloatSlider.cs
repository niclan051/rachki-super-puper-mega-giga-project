using UnityEngine;
using UnityEngine.UI;

namespace UI.Scripts {
    [RequireComponent(typeof(Slider))]
    public class PlayerPrefsFloatSlider : MonoBehaviour {
        [SerializeField] private string key;
        private Slider _slider;
        private void Start() {
            _slider = GetComponent<Slider>();
            _slider.value = PlayerPrefs.GetFloat(key);
            _slider.onValueChanged.AddListener(value => PlayerPrefs.SetFloat(key, value));
        }
    }
}