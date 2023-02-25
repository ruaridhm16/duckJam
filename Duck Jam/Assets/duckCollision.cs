using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class duckCollision : MonoBehaviour
{

    public duckCounter duckCount;
    public Renderer rend;
    public GameObject Duck;
    public GameObject Player;
    public bool isCollected;
    public boatMovement moveSpeed;
    public BoxCollider2D collider;
    public int counter = 0;

    void Start()
    {
  
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
       
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
           
            duckCounter.duckCount = duckCounter.duckCount + 1;
            Destroy(collider);
            while (counter < 100)
            {
                Duck.transform.localScale = new Vector2(Duck.transform.localScale.x - 0.1f, Duck.transform.localScale.y - 0.1f);
                Duck.transform.rotation = Quaternion.Euler(0, 0, Duck.transform.rotation.z + 10);
            }
            Destroy(Duck);

        }
    } 
}
