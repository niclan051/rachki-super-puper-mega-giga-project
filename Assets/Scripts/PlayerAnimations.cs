using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator Animator { get; private set; }
    
    public static readonly int BoolOnGround = Animator.StringToHash("On Ground");
    public static readonly int TriggerJump = Animator.StringToHash("Jump");
    public static readonly int Running = Animator.StringToHash("Running");

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
}
