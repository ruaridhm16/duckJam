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

        if (playerRotation > -0.45f && playerRotation < 0.45f)
        {
            playerPosition.Rotate(0, 0, -(horizontalInput * rotationSpeed));

        }
        else if (playerRotation <= -0.45f)
        {
            playerPosition.rotation = Quaternion.Euler(0, 0, -45F);
        }
        else if (playerRotation >= 0.45f)
        {
            playerPosition.rotation = Quaternion.Euler(0, 0, 45F);
        }

    }

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.up * moveSpeed;
    }
    
}