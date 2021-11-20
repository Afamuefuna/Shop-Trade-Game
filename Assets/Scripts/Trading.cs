using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using UnityEngine;

public class Trading : MonoBehaviour
{
    characterStats characterStats;
    itemID itemID;
    shopItemDatabase shopItemDatabase;
    collections collections;
    public void buy()
    {
        characterStats = GameObject.FindGameObjectWithTag("Player").GetComponent<characterStats>();
        itemID = gameObject.transform.GetComponentInParent<itemID>();

        if(itemID.price > characterStats.money)
        {
            Debug.Log("You do not have enough money kid");
            ShopKeeperChatOrder.shopKeeperChat = "You do not have enough money kid, got something I can buy?";
        }
        else
        {
            characterStats.money = characterStats.money - itemID.price;

            itemID.gameObject.transform.SetParent(GameObject.Find("Content wardrobe").transform);
            shopItemDatabase = GameObject.Find("shopItemDatabase").GetComponent<shopItemDatabase>();
            foreach (var item in shopItemDatabase.shopItems.ToList())
            {
                if(item.ID == itemID.ID)
                {
                    shopItemDatabase.soldItems.Add(item);
                    shopItemDatabase.shopItems.Remove(item);
                }
            }
            itemID.mItemState= itemID.state.inWardRobe;
            itemID.initializeForWardrobe();
            Debug.Log("ITEM added to wardrobe");
            ShopKeeperChatOrder.shopKeeperChat = "Nice, that would fit you so well";
            characterStats.itemsBought = characterStats.itemsBought + 1;
        }
    }

    public void sell()
    {
        ShopKeeperChatOrder.shopKeeperChat = "My wife would love this!";

        characterStats = GameObject.FindGameObjectWithTag("Player").GetComponent<characterStats>();
        itemID = gameObject.transform.GetComponentInParent<itemID>();
        collections = GameObject.FindGameObjectWithTag("Player").GetComponent<collections>();

        characterStats.money = characterStats.money + itemID.price;
        foreach (var item in collections.collectedItems.ToList())
        {
            if(item.ID == itemID.ID)
            {
                collections.collectedItems.Remove(item);
            }
        }

        Destroy(itemID.gameObject);
    }
}
