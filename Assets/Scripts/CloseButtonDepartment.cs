using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButtonDepartment : MonoBehaviour
{
    public GameObject panel, scroll;
    public Image text;
    public Sprite blue, green, white, red;
    public GameObject left, right;

    void OnMouseDown()

    {
        GetComponent<Image>().sprite = blue;
        text.GetComponent<Image>().sprite = white;
    }

    private void OnMouseUp()
    {
        GetComponent<Image>().sprite = green;
        text.GetComponent<Image>().sprite = red;
    }


    private void OnMouseUpAsButton()
    {
        GetComponent<Image>().sprite = green;
        text.GetComponent<Image>().sprite = red;
        panel.SetActive(false);
        scroll.GetComponent<ScrollRect>().horizontal = true;
        right.GetComponent<PolygonCollider2D>().enabled = true;
        left.GetComponent<PolygonCollider2D>().enabled = true;
    }

}
