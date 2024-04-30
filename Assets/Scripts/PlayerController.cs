using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed;
    [SerializeField] private float jumpVelocity;
    private CameraManager _cameraManager;
    private Rigidbody _rb;
    private GroundCollision _groundCollision;

    private void Start() {
        _cameraManager = FindObjectOfType<CameraManager>();
        _rb = GetComponent<Rigidbody>();
        _groundCollision = GetComponentInChildren<GroundCollision>();
    }

    private void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = _cameraManager.IsIn3DMode ? Input.GetAxis("Vertical") : 0;
        var moveDirection = new Vector3(horizontal, 0, vertical);
        _rb.velocity = _cameraManager.Camera2D.transform.TransformDirection(moveDirection) * speed + new Vector3(0, _rb.velocity.y, 0);

        if (_groundCollision.OnGround && Input.GetKeyDown(KeyCode.Space)) {
            Vector3 soonToBeVelocity = _rb.velocity;
            soonToBeVelocity.y = jumpVelocity;
            _rb.velocity = soonToBeVelocity;
        }
    }
}
