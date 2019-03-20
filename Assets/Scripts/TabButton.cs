using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    public Sprite active, passive;
    public Image secondTab;

    private void OnMouseUpAsButton()
    {
        if (GetComponent<Image>().sprite == passive)
        {
            GetComponent<Image>().sprite = active;
            secondTab.GetComponent<Image>().sprite = passive;
        }


    }

}
