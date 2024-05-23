using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private List<AudioClip> musicClips;

    private AudioSource _bgMusicSource;
    private float _masterVolume;
    private float _musicVolume;
    private float _sfxVolume;
    private void Start()
    {
        _bgMusicSource = GetComponent<AudioSource>();
        PlayRandomMusic();
    }
    private void Update() {
        mixer.SetFloat("masterVolume", ConvertToDb(PlayerPrefs.GetFloat("masterVolume")));
        mixer.SetFloat("musicVolume", ConvertToDb(PlayerPrefs.GetFloat("musicVolume")));
        mixer.SetFloat("sfxVolume", ConvertToDb(PlayerPrefs.GetFloat("sfxVolume")));
    }
    private void PlayRandomMusic()
    {
        _bgMusicSource.clip = musicClips[Random.Range(0, musicClips.Count)];
        _bgMusicSource.Play();
        Invoke(nameof(PlayRandomMusic), _bgMusicSource.clip.length);
    }

    private static float ConvertToDb(float value) => Mathf.Log10(value) * 20;
}
