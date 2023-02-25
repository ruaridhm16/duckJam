using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobbing : MonoBehaviour

{

    public GameObject john;
    public float counter = 0;
    public float cooldown;
    void Start()
    {
        Invoke("bobUp",1);
    }

    


    void bobUp()
    {
        john.transform.localScale = new Vector2(1.05f, 1.05f);
        Invoke("bobDown", 1f);
    }
    void bobDown()
    {
        john.transform.localScale = new Vector2(1,1);
        Invoke("bobUp", 1f);
    }
}
