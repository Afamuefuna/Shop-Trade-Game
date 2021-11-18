using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemManager : MonoBehaviour
{
    [SerializeField] shopItemDatabase itemDatabase;
    [SerializeField] GameObject items;

    private void Start()
    {
        for (int i = 0; i <= itemDatabase.shopItems.Count - 1; i++)
        {
            GameObject item = Instantiate(items, GameObject.Find("Content shop").transform);
            item.AddComponent<itemID>().ID = i;
            item.GetComponent<itemID>().name = itemDatabase.shopItems[i].name;
            item.GetComponent<itemID>().color = itemDatabase.shopItems[i].color;
            item.GetComponent<itemID>().price = itemDatabase.shopItems[i].price;
            item.GetComponent<itemID>().Icon = itemDatabase.shopItems[i].Icon;
            if(itemDatabase.shopItems[i].mItemType == ShopItem.itemType.pants)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.pants;
            }
            if (itemDatabase.shopItems[i].mItemType == ShopItem.itemType.shirt)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.shirt;
            }
            if (itemDatabase.shopItems[i].mItemType == ShopItem.itemType.shoe)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.shoe;
            }

        }
    }
}
