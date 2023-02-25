 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatMovement : MonoBehaviour
{
    public Transform playerPosition;
    public Rigidbody2D rigidbody;
    public float horizontalInput;
    public static float moveSpeed = 5f;
    public float playerRotation;
    public float rotationSpeed = 5f;
    

    


    void Start()
    {

    }

    void Update()
    {   //get inputs
        horizontalInput = Input.GetAxis("Horizontal");
        

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //move forward
        
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.up * moveSpeed;
        playerPosition.Rotate(0, 0, -(horizontalInput * rotationSpeed));
    }
}