using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Button : MonoBehaviour
{

    public Sprite no_press, press;

    void OnMouseDown()
    {
        GetComponent<Image>().sprite = press;
    }

    void OnMouseUp()
    {
        GetComponent<Image>().sprite = no_press;
    }

}
