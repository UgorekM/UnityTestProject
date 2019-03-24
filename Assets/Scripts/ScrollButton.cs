using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollButton : MonoBehaviour
{
    GameObject content, right_circle, left_circle, scroll_view;
    //public GameObject toggle_circle;// left_button, right_button;

    private void Start()
    {
        content = GameObject.Find("Content");
        scroll_view = GameObject.Find("Scroll View");
        right_circle = GameObject.Find("Right_Circle");
        left_circle = GameObject.Find("Left_Circle");

        //if (right_circle != null)
        //    right_circle.GetComponent<>;

    }

    private void OnMouseDown()
    {
        scroll_view.GetComponent<ScrollRect>().enabled = false;
    }

    private void OnMouseUp()
    {
        scroll_view.GetComponent<ScrollRect>().enabled = true;
    }



    void OnMouseUpAsButton()
    {
        if (GetComponent<Object>().name == "Left_Button" && content.GetComponent<RectTransform>().anchoredPosition.x < -600)
        {
            content.GetComponent<RectTransform>().anchoredPosition = new Vector2(content.GetComponent<RectTransform>().anchoredPosition.x + 1200, 0);
            left_circle.GetComponent<Toggle>().isOn = true;
        }
        else if (GetComponent<Object>().name == "Right_Button" && content.GetComponent<RectTransform>().anchoredPosition.x > -600)
        {
            content.GetComponent<RectTransform>().anchoredPosition = new Vector2(content.GetComponent<RectTransform>().anchoredPosition.x - 1200, 0);
            right_circle.GetComponent<Toggle>().isOn = true;
        }

        
    }
}
