using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;

public class Scroll : MonoBehaviour
{
    //private RectTransform contentRect;
    Vector2 position;

    bool _scroll;

    float pos, posBeg;

    float q = 20;

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
               GetComponent<ChangeActive>().a_l.GetComponent<Renderer>().enabled = true;
               GetComponent<ChangeActive>().a_r.GetComponent<Renderer>().enabled = false;

            } else if((GetComponent<RectTransform>().anchoredPosition.x < -600) & (GetComponent<RectTransform>().anchoredPosition.x > -1800))
            {
                GetComponent<ChangeActive>().a_l.GetComponent<Renderer>().enabled = false;
                GetComponent<ChangeActive>().a_r.GetComponent<Renderer>().enabled = true;
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