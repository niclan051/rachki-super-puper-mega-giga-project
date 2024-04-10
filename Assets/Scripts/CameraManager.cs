using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Camera camera3D, camera2D;

    private bool _isIn3DMode = true;

    private CinemachineFreeLook _cinemachineFreeLook;

    // Update is called once per frame
    private void Start()
    {
        _cinemachineFreeLook = camera3D.GetComponent<CinemachineFreeLook>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) _isIn3DMode = !_isIn3DMode;
        camera3D.enabled = _isIn3DMode;
        camera2D.enabled = !_isIn3DMode;

        _cinemachineFreeLook.enabled = _isIn3DMode;
    }
}
