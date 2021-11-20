using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrandMaChatOrder : MonoBehaviour
{
    public ChatSystem GrandMaChatSystem, TerryChatSystem;

    int ChatCount;

    [SerializeField] string TerryChat, GrandMaChat;

    [SerializeField] TMP_Text TerryText, GrandMaText;

    [SerializeField] GameObject GrandMaChatBox, TerryChatBox, NextButton;

    [SerializeField] public static bool isChatOn;

    private void Start()
    {
        if (GameManager.Instance.currentActivity == GameManager.Activity.onIntro)
        {
            introChatOrder();
        }
        else
        {
            GrandMaChatBox.SetActive(false);
            TerryChatBox.SetActive(false);
            NextButton.SetActive(false);
        }
    }
    public void introChatOrder()
    {
        switch (ChatCount)
        {
            case 0:
                isChatOn = true;
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[0];
                break;
            case 1:
                TerryChat = TerryChatSystem.chats[0].Discussion[0];
                break;
            case 2:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[1];
                break;
            case 3:
                TerryChat = TerryChatSystem.chats[0].Discussion[1];
                break;
            case 4:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[2];
                break;
            case 5:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[3];
                break;
            case 6:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[4];
                break;
            case 7:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[5];
                characterStats.money = characterStats.money + 100;
                break;
            case 8:
                GrandMaChat = GrandMaChatSystem.chats[0].Discussion[6];
                break;
            case 9:
                TerryChat = TerryChatSystem.chats[0].Discussion[2];
                break;
            default:
                isChatOn = false;
                GrandMaChatBox.SetActive(false);
                TerryChatBox.SetActive(false);
                NextButton.SetActive(false);
                GameManager.Instance.currentActivity = GameManager.Activity.onTask;
                break;
        }

        TerryText.text = TerryChat;
        GrandMaText.text = GrandMaChat;
        ChatCount++;
    }
}
