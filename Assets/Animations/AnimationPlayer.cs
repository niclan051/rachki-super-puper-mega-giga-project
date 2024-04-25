using UnityEngine;

namespace Animations {
    public class AnimationPlayer : MonoBehaviour
    {
        public void PlayAnimation(Animation animation) => animation.Play();
    }
}
