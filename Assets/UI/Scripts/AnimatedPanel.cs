using UnityEngine;

namespace UI.Scripts {
    [RequireComponent(typeof(Animation))]
    public class AnimatedPanel : MonoBehaviour {
        [SerializeField] private AnimationClip openAnimation;
        [SerializeField] private AnimationClip closeAnimation;
        private Animation _animation;
        private void Start() { _animation = GetComponent<Animation>(); }

        public void PlayAnimation(AnimationClip clip) {
            _animation.clip = clip;
            _animation.Play();
        }
        public void PlayOpenAnimation() => PlayAnimation(openAnimation);
        public void PlayCloseAnimation() => PlayAnimation(closeAnimation);
    }
}
