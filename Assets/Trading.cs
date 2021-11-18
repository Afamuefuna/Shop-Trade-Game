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
    public void buy()
    {
        characterStats = GameObject.FindGameObjectWithTag("Player").GetComponent<characterStats>();
        itemID = gameObject.transform.GetComponentInParent<itemID>();

        if(itemID.price > characterStats.money)
        {
            Debug.Log("You do not have enough money kid");

        }
        else
        {
            itemID.gameObject.transform.SetParent(GameObject.Find("Content wardrobe").transform);
            shopItemDatabase = GameObject.Find("shopItemDatabase").GetComponent<shopItemDatabase>();
            foreach (var item in shopItemDatabase.shopItems.ToList())
            {
                if(shopItemDatabase.shopItems.IndexOf(item) == itemID.ID)
                {
                    shopItemDatabase.shopItems.Remove(item);
                }
            }
            Debug.Log("ITEM added to wardrobe");
        }
    }
}
