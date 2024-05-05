using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Util {
    public class SceneLoader : MonoBehaviour {
        public void LoadScene(int index) {
            SceneManager.LoadScene(index);
        }
    }
}