using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ShopItem
{
    public string name;
    public GameObject Icon;
    public float price;
    public Color32 color;
    public int ID;
    public enum itemType
    {
        pants,
        shirt,
        shoe
    }

    public itemType mItemType;
}
