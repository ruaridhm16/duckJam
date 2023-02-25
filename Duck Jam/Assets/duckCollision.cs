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

    void Start()
    {
  
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollected)
        {
            Duck.transform.position = Vector2.MoveTowards(Duck.transform.position, Player.transform.position, 0.0058f);
            //boatMovement.moveSpeed
        }
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
       
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
           
            duckCounter.duckCount = duckCounter.duckCount + 1;
            Destroy(collider);
            Duck.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y - (1 * duckCounter.duckCount));
            isCollected = true;

        }
    } 
}
