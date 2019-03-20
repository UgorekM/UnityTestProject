using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageButton : MonoBehaviour
{
    public Sprite press, no_press;

    void OnMouseDown()

    {
        GetComponent<Image>().sprite = press;
    }

    void OnMouseUp()
    {
        GetComponent<Image>().sprite = no_press;
    }
}
