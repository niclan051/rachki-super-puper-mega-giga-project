using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : DontDestroyOnLoad {
    [SerializeField] private List<SceneAsset> levels;
    public int CurrentLevelIndex { get; set; }

    public void LoadLevel(int index) {
        CurrentLevelIndex = index;
        try {
            SceneManager.LoadScene(levels[index].name);
            PlayerPrefs.SetInt("levelIndex", CurrentLevelIndex);
        }
        catch (ArgumentOutOfRangeException) {
            Debug.LogError($"Tried to load level {index + 1} which does not exist");
        }
    }

    public void StartGame() {
        LoadLevel(0);
    }
    public void LoadSavedLevel() {
        LoadLevel(PlayerPrefs.GetInt("levelIndex", 0));
    }
}