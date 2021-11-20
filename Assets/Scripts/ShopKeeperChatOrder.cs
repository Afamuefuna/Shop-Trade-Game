using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopKeeperChatOrder : MonoBehaviour
{
    public static string shopKeeperChat;
    [SerializeField] TMP_Text shopKeeperText;

    // Start is called before the first frame update
    void Start()
    {
        shopKeeperChat = "Welcome Kid!, what do you want?";
    }

    // Update is called once per frame
    void Update()
    {
        shopKeeperText.text = shopKeeperChat;
    }
}
