using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class duckRemover : MonoBehaviour
{

    public duckCounter duckCount;
    public Renderer rend;
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
           
            rend.enabled = false;
            duckCounter.duckCount = duckCounter.duckCount + 1;
        }
    }
}
