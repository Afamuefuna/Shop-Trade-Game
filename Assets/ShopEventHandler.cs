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
    }

    public void sell()
    {
        sellPanel.SetActive(true);
        ShopPanel.SetActive(false);
        WardrobePanel.SetActive(false);
        closeShopPanelButton.SetActive(true);
    }

    public void wardRobe()
    {
        WardrobePanel.SetActive(true);
        closeShopPanelButton.SetActive(true);
    }

    public void chat()
    {

    }

    public void closeShopPanels()
    {
        WardrobePanel.SetActive(false);
        ShopPanel.SetActive(false);
        closeShopPanelButton.SetActive(false);
        sellPanel.SetActive(false);
    }
}
