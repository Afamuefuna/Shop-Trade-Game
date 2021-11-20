using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellItemManager : MonoBehaviour
{
    [SerializeField] public collections collections;
    [SerializeField] GameObject items;

    private void OnEnable()
    {
        collections = GameObject.Find("Player").GetComponent<collections>();
        if (gameObject.transform.childCount != 0)
        {
            return;
        }
        for (int i = 0; i <= collections.collectedItems.Count - 1; i++)
        {
            GameObject item = Instantiate(items, GameObject.Find("Content sell").transform);
            item.AddComponent<itemID>().ID = i;
            item.GetComponent<itemID>().name = collections.collectedItems[i].name;
            item.GetComponent<itemID>().color = collections.collectedItems[i].color;
            item.GetComponent<itemID>().price = collections.collectedItems[i].price;
            item.GetComponent<itemID>().Icon = collections.collectedItems[i].Icon;
            if (collections.collectedItems[i].mItemType == ShopItem.itemType.pants)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.pants;
            }
            if (collections.collectedItems[i].mItemType == ShopItem.itemType.shirt)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.shirt;
            }
            if (collections.collectedItems[i].mItemType == ShopItem.itemType.shoe)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.shoe;
            }
            if (collections.collectedItems[i].mItemType == ShopItem.itemType.collectible)
            {
                item.GetComponent<itemID>().mItemType = itemID.itemType.collectible;
            }

        }
    }
}
