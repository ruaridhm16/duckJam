using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colliderDeath : MonoBehaviour
{
    public duckCounter duckCount;
    public GameObject Player;
    public SpriteRenderer sr;
    public Renderer rend;
    public Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        originalColor = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level1");
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (SceneManager.GetActiveScene().name == "Level3")
            {
                SceneManager.LoadScene("Level3");
            }
            //Add more scenes here

            duckCounter.duckCount = 0;
            sr.color = Color.red;
            Invoke("colorChangeBack", 0.5f);
            rend.enabled = true;


        }
    }

    private void colorChangeBack()
    {
        sr.color = originalColor;
    }

}
