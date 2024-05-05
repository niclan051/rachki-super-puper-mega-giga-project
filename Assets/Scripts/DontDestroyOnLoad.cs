using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {
    protected virtual void Start() {
        DontDestroyOnLoad(gameObject);
    }
}