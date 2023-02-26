 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boatMovement : MonoBehaviour
{
    public Transform playerPosition;
    public Rigidbody2D rb;
    public float horizontalInput;
    public static float moveSpeed = 3f;
    public float playerRotation;
    public float rotationSpeed = 6f;
    

    


    void Start()
    {

    }

    void Update()
    {   //get inputs
        horizontalInput = Input.GetAxis("Horizontal");
        

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelSelect");
        }

        //move forward
        
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            playerPosition.Rotate(0, 0, rotationSpeed);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerPosition.Rotate(0, 0, -rotationSpeed);
        }
    }
}