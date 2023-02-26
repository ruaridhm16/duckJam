using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class duckCounter : MonoBehaviour
{
    private string textVariable;
    public Text countDisplay;
    public static int duckCount;

    [Header("Duck Display")]
    public Image duckDisplay;
    public Sprite duck0;
    public Sprite duck1;
    public Sprite duck2;
    public Sprite duck3;
    public Sprite duck4;
    public Sprite duck5;

    void Start()
    {
        countDisplay.text = "Ducks: 0";
    
    }

    
    void Update()
    {   
        textVariable = "Ducks: " + duckCount;
        countDisplay.text = textVariable;
        if (duckCount == 0)
        {
            duckDisplay.sprite = duck0;
        }
        else if (duckCount == 1)
        {
            duckDisplay.sprite = duck1;
        }
        else if (duckCount == 2)
        {
            duckDisplay.sprite = duck2;
        }
        else if (duckCount == 3)
        {
            duckDisplay.sprite = duck3;
        }
        else if (duckCount == 4)
        {
            duckDisplay.sprite = duck4;
        }
        else
        {
            duckDisplay.sprite = duck5;
        }

    }
}
