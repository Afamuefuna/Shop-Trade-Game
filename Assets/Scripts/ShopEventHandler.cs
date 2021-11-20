using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopEventHandler : MonoBehaviour
{
    [SerializeField] GameObject ShopPanel, WardrobePanel, closeShopPanelButton, sellPanel;

    private void Start()
    {
        sellPanel.SetActive(false);
        ShopPanel.SetActive(false);
        WardrobePanel.SetActive(false);
        closeShopPanelButton.SetActive(false);
    }
    public void buy()
    {
        ShopPanel.SetActive(true);
        WardrobePanel.SetActive(true);
        closeShopPanelButton.SetActive(true);
        ShopKeeperChatOrder.shopKeeperChat = "What are you buying today?";
    }

    public void sell()
    {
        sellPanel.SetActive(true);
        ShopPanel.SetActive(false);
        WardrobePanel.SetActive(false);
        closeShopPanelButton.SetActive(true);
        ShopKeeperChatOrder.shopKeeperChat = "Let's see what available to buy";
    }

    public void wardRobe()
    {
        WardrobePanel.SetActive(true);
        closeShopPanelButton.SetActive(true);
        ShopKeeperChatOrder.shopKeeperChat = " ";
    }

    public void closeShopPanels()
    {
        WardrobePanel.SetActive(false);
        ShopPanel.SetActive(false);
        closeShopPanelButton.SetActive(false);
        sellPanel.SetActive(false);
        ShopKeeperChatOrder.shopKeeperChat = "Are you going?";
    }
}
