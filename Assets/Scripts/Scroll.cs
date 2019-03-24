using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    //private RectTransform contentRect;
    Vector2 position;
    bool _scroll;
    float pos, posBeg;
    float q = 20;
    GameObject right_circle, left_circle;

    private void Start()
    {
        right_circle = GameObject.Find("Right_Circle");
        left_circle = GameObject.Find("Left_Circle");
    }

    public void Scrolling(bool scroll)
    {
        _scroll = scroll;
    }


    private void FixedUpdate()
    {
        if (_scroll)
        {
            if((GetComponent<RectTransform>().anchoredPosition.x > -600) & (GetComponent<RectTransform>().anchoredPosition.x < 600))
            {
                left_circle.GetComponent<Toggle>().isOn = true;

            } else if((GetComponent<RectTransform>().anchoredPosition.x < -600) & (GetComponent<RectTransform>().anchoredPosition.x > -1800))
            {
                right_circle.GetComponent<Toggle>().isOn = true;
            }
                

            return;
        }

        if ((GetComponent<RectTransform>().anchoredPosition.x > -600))
        {
            position.x = Mathf.SmoothStep(GetComponent<RectTransform>().anchoredPosition.x, 0, q * Time.fixedDeltaTime);
            pos = GetComponent<RectTransform>().anchoredPosition.x;
        }
        else if ((GetComponent<RectTransform>().anchoredPosition.x < -600))
        {
            position.x = Mathf.SmoothStep(GetComponent<RectTransform>().anchoredPosition.x, -1200, q * Time.fixedDeltaTime);
            pos = GetComponent<RectTransform>().anchoredPosition.x;
        }
        
 
            GetComponent<RectTransform>().anchoredPosition = position;
    }

}