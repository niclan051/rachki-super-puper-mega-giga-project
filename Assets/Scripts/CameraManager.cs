using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Camera camera3D, camera2D;
    public Camera Camera3D => camera3D;
    public Camera Camera2D => camera2D;

    public bool IsIn3DMode { get; private set; } = true;

    private CinemachineFreeLook _cinemachineFreeLook;

    // Update is called once per frame
    private void Start()
    {
        _cinemachineFreeLook = camera3D.GetComponent<CinemachineFreeLook>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) IsIn3DMode = !IsIn3DMode;
        camera3D.enabled = IsIn3DMode;
        camera2D.enabled = !IsIn3DMode;

        _cinemachineFreeLook.enabled = IsIn3DMode;
    }
}
