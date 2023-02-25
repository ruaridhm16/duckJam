using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDeath : MonoBehaviour
{
    public duckCounter duckCount;
    public GameObject Player;
    public SpriteRenderer sr;
    public int numberOfLives = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Player.transform.position = new Vector3(0, 0, 0);
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            duckCounter.duckCount = 0;
            sr.color = Color.red;
            Invoke("colorChangeBack", 0.5f);
            rend.enabled = true;


        }
    }

    private void colorChangeBack()
    {
        sr.color = new Color(181, 143, 98);
    }

}
