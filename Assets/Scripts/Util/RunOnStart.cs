using UnityEngine;
using UnityEngine.Events;

public class RunOnStart : MonoBehaviour
{
    [SerializeField] private UnityEvent actions;
    private void Start() => actions.Invoke();
}