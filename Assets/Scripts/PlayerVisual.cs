using UnityEngine;

public class PlayerVisual : MonoBehaviour {
    private Rigidbody _rb;
    private Vector3 _oldLookRotation;

    private void Start() {
        _rb = GetComponentInParent<Rigidbody>();
    }

    private void Update() {
        Vector3 velocity = _rb.velocity;
        if (new Vector2(velocity.x, velocity.z).magnitude > 0.001f) {
            _oldLookRotation = velocity;
        }
        Quaternion rotation = Quaternion.LookRotation(_oldLookRotation);

        Vector3 eulerAngles = rotation.eulerAngles;
        eulerAngles.x = 0;
        rotation = Quaternion.Euler(eulerAngles);
        
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10);
    }
}