using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDepartment : MonoBehaviour
{

    public Image text;
    public Sprite blue, green, white, red;

    void OnMouseDown()

    {
        GetComponent<Image>().sprite = blue;
        text.GetComponent<Image>().sprite = white;
    }

    void OnMouseUp()
    {
        GetComponent<Image>().sprite = green;
        text.GetComponent<Image>().sprite = red;
    }

}
