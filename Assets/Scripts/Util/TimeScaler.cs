using UnityEngine;

namespace Util
{
    public class TimeScaler : MonoBehaviour
    {
        public void SetTimeScale(float scale) => Time.timeScale = scale;
    }
}