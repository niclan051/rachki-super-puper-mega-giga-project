using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed;
    [SerializeField] private float jumpVelocity;
    [SerializeField] private Transform cameraAnchor;
    private Rigidbody _rb;
    private GroundCollision _groundCollision;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        _groundCollision = GetComponentInChildren<GroundCollision>();
    }

    private void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        var moveDirection = new Vector3(horizontal, 0, vertical);
        Vector3 transformedDirection = cameraAnchor.TransformDirection(moveDirection) * speed;
        Vector3 soonToBeVelocity = _rb.velocity;
        soonToBeVelocity.x = transformedDirection.x;
        soonToBeVelocity.z = transformedDirection.z;

        if (_groundCollision.OnGround && Input.GetKeyDown(KeyCode.Space)) {
            soonToBeVelocity.y = jumpVelocity;
        }
        _rb.velocity = soonToBeVelocity;
    }
}
