using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New cell", menuName = "CellOfStore")]

public class CellOfStore : ScriptableObject
{
    public string name;
    public float price;
    public Sprite image;
}
