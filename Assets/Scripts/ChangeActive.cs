using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActive : MonoBehaviour
{
    public GameObject a_l, a_r;

    private void Start()
    {
        a_l.GetComponent<Renderer>().enabled = true;
        a_r.GetComponent<Renderer>().enabled = false;
    }

    public void ChangeCircles()
    {
        a_l.GetComponent<Renderer>().enabled = !a_l.GetComponent<Renderer>().enabled;
        a_r.GetComponent<Renderer>().enabled = !a_r.GetComponent<Renderer>().enabled;
    }
}
