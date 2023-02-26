using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] public GameObject text;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (text.tag == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
        else if (text.tag == "Level2")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (text.tag == "Level3")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
