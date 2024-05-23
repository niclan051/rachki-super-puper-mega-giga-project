using UnityEngine;

public class CopyTransform : MonoBehaviour
{
    [SerializeField] private Transform origin;
    [SerializeField] private bool copyPositionX, copyPositionY, copyPositionZ;
    [SerializeField] private bool copyRotationX, copyRotationY, copyRotationZ;
    [SerializeField] private bool copyScaleX, copyScaleY, copyScaleZ;
    private void Update()
    {
        transform.position = new Vector3(
            (copyPositionX ? origin : transform).position.x,
            (copyPositionY ? origin : transform).position.y,
            (copyPositionZ ? origin : transform).position.z
        );
        transform.rotation = Quaternion.Euler(
            (copyRotationX ? origin : transform).rotation.eulerAngles.x,
            (copyRotationY ? origin : transform).rotation.eulerAngles.y,
            (copyRotationZ ? origin : transform).rotation.eulerAngles.z
        );
        transform.localScale = new Vector3(
            (copyScaleX ? origin : transform).localScale.x,
            (copyScaleY ? origin : transform).localScale.y,
            (copyScaleZ ? origin : transform).localScale.z
        );
    }
}