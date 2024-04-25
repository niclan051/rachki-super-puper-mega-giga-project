using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : DontDestroyOnLoad {
    [SerializeField] private AudioMixer mixer;
    private float _masterVolume;
    private float _musicVolume;
    private float _sfxVolume;

    private void Update() {
        mixer.SetFloat("masterVolume", ConvertToDb(PlayerPrefs.GetFloat("masterVolume")));
        mixer.SetFloat("musicVolume", ConvertToDb(PlayerPrefs.GetFloat("musicVolume")));
        mixer.SetFloat("sfxVolume", ConvertToDb(PlayerPrefs.GetFloat("sfxVolume")));
    }

    private static float ConvertToDb(float value) => Mathf.Log10(value) * 20;
}
