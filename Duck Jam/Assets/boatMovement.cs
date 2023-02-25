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
    {   //get inputs
        horizontalInput = Input.GetAxis("Horizontal");
        playerRotation = playerPosition.rotation.z;
        playerPosition.Rotate(0, 0, -(horizontalInput * rotationSpeed));
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        //move forward
        rigidbody.velocity = transform.up * moveSpeed;
    }
}