using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDeath : MonoBehaviour
{

    public GameObject Player;
    public SpriteRenderer sr;
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

            sr.color = Color.red;
            Invoke("colorChangeBack", 0.2f);
            
        }
    }

    private void colorChangeBack()
    {
        sr.color = Color.white;
    }

}
