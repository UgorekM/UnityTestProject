using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalDepartment : MonoBehaviour
{

    public GameObject panel;
    public GameObject scroll;
    public GameObject left, right;

    private void Start()
    {
        panel.SetActive(false);
    }

 
    void OnMouseUpAsButton()
    {
        scroll.GetComponent<ScrollRect>().horizontal = false;
        panel.SetActive(true);
        right.GetComponent<PolygonCollider2D>().enabled = false;
        left.GetComponent<PolygonCollider2D>().enabled = false;

    }


}




