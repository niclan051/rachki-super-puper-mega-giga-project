using System;
using UnityEngine;

public class GroundCollision : MonoBehaviour {
    public bool OnGround { get; private set; }

    private void OnTriggerStay(Collider other) => OnGround = true;
    private void OnTriggerExit(Collider other) => OnGround = false;
}