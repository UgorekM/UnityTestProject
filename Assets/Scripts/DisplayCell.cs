using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCell : MonoBehaviour
{
    const int cells = 8;

    GameObject panel_tab1, panel_tab2;
    public GameObject cell_tab_pref;

    public CellOfStore my_cell_tab1;
    public CellOfStore my_cell_tab2;


    GameObject[] cells_tab1 = new GameObject[cells];
    GameObject[] cells_tab2 = new GameObject[cells];


    public Text name, price;
    public Image image;

    void InstanceArr(CellOfStore my_cell_tab, GameObject[] cells_tab, GameObject panel_tab)
    {
        name.text = my_cell_tab.name;
        image.sprite = my_cell_tab.image;
        price.text = my_cell_tab.price.ToString();

        for (int i = 0; i < cells; ++i)
        {
            cells_tab[i] = cell_tab_pref;
            Instantiate(cells_tab[i], panel_tab.transform, false);
        }
    }

    void Start()
    {
        panel_tab1 = GameObject.Find("Panel_Of_Cells1");
        panel_tab2 = GameObject.Find("Panel_Of_Cells2");

        
        InstanceArr(my_cell_tab1,cells_tab1, panel_tab1);

        InstanceArr(my_cell_tab2, cells_tab2, panel_tab2);
               
    }
}