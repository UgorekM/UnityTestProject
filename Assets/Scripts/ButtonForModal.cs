using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonForModal : MonoBehaviour
{

    GameObject scroll_view, left_button, right_button;
    public GameObject modal_panel1, modal_panel2;
    Object this_button;

    private void Start()
    {
        scroll_view = GameObject.Find("Scroll View");
        left_button = GameObject.Find("Left_Button");
        right_button = GameObject.Find("Right_Button");
    }
 
    public void Click(string function)
    {
        if (function == "open_modal1")
        {
            scroll_view.GetComponent<ScrollRect>().enabled = false;
            right_button.GetComponent<PolygonCollider2D>().enabled = false;
            left_button.GetComponent<PolygonCollider2D>().enabled = false;
            modal_panel1.SetActive(true);          
        }

        if (function == "close_modal1")
        {
            scroll_view.GetComponent<ScrollRect>().enabled = true;
            right_button.GetComponent<PolygonCollider2D>().enabled = true;
            left_button.GetComponent<PolygonCollider2D>().enabled = true;
            modal_panel1.SetActive(false);
        }
         if(function == "comics")
        {
            Application.LoadLevel("Comics");
        }
    }
}




