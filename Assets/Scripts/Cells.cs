using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cells : MonoBehaviour
{
    GameObject panel_tab1, panel_tab2;
    int cells = 8;
    public CellOfStore prf1, prf2;
    CellOfStore[] cells_tab1 = new CellOfStore[8];
    CellOfStore[] cells_tab2 = new CellOfStore[8];
    
    void Start()
    {
        panel_tab1 = GameObject.Find("Panel_Of_Cells1");
        panel_tab2 = GameObject.Find("Panel_Of_Cells2");

        for (int i = 0; i < cells; ++i)
        {
            cells_tab1[i] = Instantiate(prf1, panel_tab1.transform);
            cells_tab2[i] = Instantiate(prf2, panel_tab2.transform);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
