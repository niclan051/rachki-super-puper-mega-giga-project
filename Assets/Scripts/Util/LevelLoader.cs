using UnityEngine;
using UnityEngine.SceneManagement;

namespace Util
{
    public class LevelLoader : MonoBehaviour 
    {
        private LevelManager _levelManager;

        private void Start() {
            _levelManager = FindObjectOfType<LevelManager>();
        }

        public void LoadNextLevel() {
            _levelManager.LoadLevel(++_levelManager.CurrentLevelIndex);
        }

        public void ReloadLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}