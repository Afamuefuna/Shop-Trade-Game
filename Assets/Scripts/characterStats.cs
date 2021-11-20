using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class characterStats : MonoBehaviour
{
    public static float money;
    public static float itemsBought;

    public TMP_Text moneyText;
    public TMP_Text itemsBoughtText;

    private void Update()
    {
        moneyText.text = "coins " + money.ToString();
        if(itemsBought >= 5)
        {
            GameManager.Instance.currentActivity = GameManager.Activity.onTaskComplete;
            itemsBoughtText.text = "Congrats. Game over";
        }
        else
        {
            itemsBoughtText.text = "items bought " + itemsBought.ToString() + "/5";
        }
    }
}
