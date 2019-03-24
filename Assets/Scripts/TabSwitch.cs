using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabSwitch : MonoBehaviour
{

    public GameObject tab1, tab2, panel1, panel2;
    
    void FixedUpdate()
    {
        if(tab1.GetComponent<Toggle>().isOn == true)
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }
        else
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
    } 

}
