using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{
    itemID itemID;
    [SerializeField] SpriteRenderer pants, shirt, shoe;

    private void Start()
    {
        itemID = gameObject.GetComponentInParent<itemID>();
        pants = GameObject.Find("Pants").GetComponent<SpriteRenderer>();
        shirt = GameObject.Find("Shirt").GetComponent<SpriteRenderer>();
        shoe = GameObject.Find("Shoe").GetComponent<SpriteRenderer>();
    }

    public void EquipCloth()
    {
        if(itemID.mItemType == itemID.itemType.pants)
        {
            changeClothColor(pants, itemID.color);
        }
        if(itemID.mItemType == itemID.itemType.shirt)
        {
            changeClothColor(shirt, itemID.color);
        }
        if (itemID.mItemType == itemID.itemType.shoe)
        {
            changeClothColor(shoe, itemID.color);
        }
    }

    public void changeClothColor(SpriteRenderer sprite, Color32 color)
    {
        sprite.color = color;
    }
}
