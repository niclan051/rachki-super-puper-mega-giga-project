using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent onPlayerEnter;
    [SerializeField] private UnityEvent onPlayerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(player.tag)) onPlayerEnter.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(player.tag)) onPlayerExit.Invoke();
    }
}