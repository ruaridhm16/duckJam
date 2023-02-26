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
        rend = Duck.GetComponent<SpriteRenderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollected && counter < 10)
        {
            Duck.transform.localScale = new Vector2(Duck.transform.localScale.x - 0.01f, Duck.transform.localScale.y - 0.01f);
            Duck.transform.rotation = Quaternion.Euler(0, 0, Duck.transform.rotation.z + 2);
            counter += 1;
        }
        else if (isCollected && counter >= 10)
        {
            Destroy(Duck);
        }
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
       
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
           
            duckCounter.duckCount = duckCounter.duckCount + 1;
            Destroy(collider);
            isCollected = true;
        }
    } 
}
