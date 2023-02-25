using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class duckCounter : MonoBehaviour
{
    private string textVariable;
    public TMP_Text countDisplay;
    public static int duckCount;

    void Start()
    {
        countDisplay.text = "Ducks: 0";
    
    }

    
    void Update()
    {   
        textVariable = "Ducks: " + duckCount;
        countDisplay.text = textVariable;
    }
}
