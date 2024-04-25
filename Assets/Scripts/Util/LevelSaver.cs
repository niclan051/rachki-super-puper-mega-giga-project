using System;
using UnityEngine;

namespace Util {
    public class LevelSaver : MonoBehaviour {
        private LevelManager _levelManager;

        private void Start() {
            _levelManager = FindObjectOfType<LevelManager>();
        }

        public void SaveCurrentLevel() {
            PlayerPrefs.SetInt("levelIndex", ++_levelManager.CurrentLevelIndex);
        }
    }
}