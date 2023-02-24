 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour
{
    public Transform playerPosition;
    public Rigidbody2D rigidbody;
    public float horizontalInput;
    public float moveSpeed = 5f;
    public float verticalMoveSpeed = 3f;
    public float playerRotation;
    public float rotationSpeed = 3f;

    void Start()
    {

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerRotation = playerPosition.rotation.z;

        playerPosition.Rotate(0, 0, -Mathf.Clamp(horizontalInput * rotationSpeed, -0.25f, 0.25f));
        
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = transform.up * moveSpeed;
    }
}