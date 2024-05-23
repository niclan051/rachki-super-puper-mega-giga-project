using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int CurrentLevelIndex { get; set; }

    private void Start()
    {
        CurrentLevelIndex = PlayerPrefs.GetInt("levelIndex", 1);
    }
    public void LoadLevel(int index) {
        CurrentLevelIndex = index;
        try {
            SceneManager.LoadScene(CurrentLevelIndex);
            PlayerPrefs.SetInt("levelIndex", CurrentLevelIndex);
        }
        catch (ArgumentOutOfRangeException) {
            Debug.LogError($"Tried to load level {index + 1} which does not exist");
        }
    }

    public void StartGame() {
        LoadLevel(1);
    }
    public void LoadSavedLevel() {
        LoadLevel(PlayerPrefs.GetInt("levelIndex", 1));
    }
}