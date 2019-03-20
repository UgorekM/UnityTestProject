using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;

public class ScrollButton : MonoBehaviour
{
    public string side;
    public GameObject panel1, panel2, content;

    Vector2 v;


    void OnMouseUpAsButton()
    {
        //content.GetComponent<Scroll>().Scrolling(true);

        if (side == "left" && content.GetComponent<RectTransform>().anchoredPosition.x < -600)
        {
            content.GetComponent<RectTransform>().anchoredPosition = new Vector2(content.GetComponent<RectTransform>().anchoredPosition.x + 1200, 0);
            GetComponent<ChangeActive>().ChangeCircles();
        }
        else if (side == "right" && content.GetComponent<RectTransform>().anchoredPosition.x > -600)
        {
            content.GetComponent<RectTransform>().anchoredPosition = new Vector2(content.GetComponent<RectTransform>().anchoredPosition.x - 1200, 0);
            GetComponent<ChangeActive>().ChangeCircles();
        }

        
    }
}
