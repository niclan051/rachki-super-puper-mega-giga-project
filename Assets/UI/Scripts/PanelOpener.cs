using UnityEngine;

namespace UI.Scripts {
    public class PanelOpener : MonoBehaviour
    {
        public void OpenPanel(AnimatedPanel panel) => panel.PlayOpenAnimation();
        public void ClosePanel(AnimatedPanel panel) => panel.PlayCloseAnimation();
    }
}
