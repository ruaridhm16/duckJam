using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartButton : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    private Color ogColor;
    public Text text;
    void Start()
    {
        ogColor = text.color;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("mouse enter");
        text.color = new Color(87, 50, 40, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = ogColor;
    }
}
