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
        GetComponent<SpriteRenderer>().sprite = press;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = no_press;
    }

}
