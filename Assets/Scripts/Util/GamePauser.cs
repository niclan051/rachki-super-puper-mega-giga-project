using UnityEngine;
using UnityEngine.Events;

public class GamePauser : MonoBehaviour
{
    [SerializeField] private UnityEvent onPause, onUnpause;
    public bool Paused { get; private set; }
    public void Pause()
    {
        onPause.Invoke();
        Paused = true;
    }
    public void Unpause()
    {
        onUnpause.Invoke();
        Paused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused) Pause();
        }
    }
}