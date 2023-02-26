using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler
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
        
        text.color = Color.gray;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = ogColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
