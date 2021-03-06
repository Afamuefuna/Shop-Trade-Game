using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemManager : MonoBehaviour
{
    [SerializeField] shopItemDatabase itemDatabase;
    [SerializeField] GameObject items;

    private void OnEnable()
    {
        if(gameObject.name == "Content shop")
        {
            itemDatabase = GameObject.Find("shopItemDatabase").gameObject.GetComponent<shopItemDatabase>();
            if (gameObject.transform.childCount != 0)
            {
                return;
            }
            for (int i = 0; i <= itemDatabase.shopItems.Count - 1; i++)
            {
                GameObject item = Instantiate(items, GameObject.Find("Content shop").transform);
                item.AddComponent<itemID>().ID = i;
                item.GetComponent<itemID>().name = itemDatabase.shopItems[i].name;
                item.GetComponent<itemID>().color = itemDatabase.shopItems[i].color;
                item.GetComponent<itemID>().price = itemDatabase.shopItems[i].price;
                item.GetComponent<itemID>().Icon = itemDatabase.shopItems[i].Icon;
                if (itemDatabase.shopItems[i].mItemType == ShopItem.itemType.pants)
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
                item.GetComponent<itemID>().mItemState = itemID.state.inStore;
            }
        }
        if(gameObject.name == "Content wardrobe")
        {
            itemDatabase = GameObject.Find("shopItemDatabase").gameObject.GetComponent<shopItemDatabase>();
            if (gameObject.transform.childCount != 0)
            {
                return;
            }
            for (int i = 0; i <= itemDatabase.soldItems.Count - 1; i++)
            {
                GameObject item = Instantiate(items, GameObject.Find("Content wardrobe").transform);
                item.AddComponent<itemID>().ID = i;
                item.GetComponent<itemID>().name = itemDatabase.soldItems[i].name;
                item.GetComponent<itemID>().color = itemDatabase.soldItems[i].color;
                item.GetComponent<itemID>().price = itemDatabase.soldItems[i].price;
                item.GetComponent<itemID>().Icon = itemDatabase.soldItems[i].Icon;
                if (itemDatabase.soldItems[i].mItemType == ShopItem.itemType.pants)
                {
                    item.GetComponent<itemID>().mItemType = itemID.itemType.pants;
                }
                if (itemDatabase.soldItems[i].mItemType == ShopItem.itemType.shirt)
                {
                    item.GetComponent<itemID>().mItemType = itemID.itemType.shirt;
                }
                if (itemDatabase.soldItems[i].mItemType == ShopItem.itemType.shoe)
                {
                    item.GetComponent<itemID>().mItemType = itemID.itemType.shoe;
                }

                item.GetComponent<itemID>().mItemState = itemID.state.inWardRobe;
                item.GetComponent<itemID>().initializeForWardrobe();

            }
        }
        
    }
}
