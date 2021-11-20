using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemID : MonoBehaviour
{
    public int ID;
    public string name;
    public GameObject Icon;
    public float price;
    public Color32 color;
    public enum state
    {
        inStore,
        inWardRobe,
        inEquip
    }

    public enum itemType
    {
        pants,
        shirt,
        shoe,
        collectible
    }

    public itemType mItemType;

    public state mItemState;

    public TMP_Text nameText;
    public TMP_Text priceText;
    public Image[] iconImage;

    private void Start()
    {
        nameText = gameObject.transform.GetChild(0).GetComponent<TMP_Text>();
        nameText.text = name.ToString();

        GameObject newIcon =
            Instantiate(Icon, gameObject.transform);

        newIcon.name = "Icon";
        newIcon.transform.SetSiblingIndex(1);

        iconImage = gameObject.transform.Find("Icon").gameObject.transform.GetComponentsInChildren<Image>();
        foreach (var image in iconImage)
        {
            image.color = new Color32(color.r, color.g, color.b, color.a);
        }

        if (mItemState == state.inStore)
        {
            nameText = gameObject.transform.GetChild(0).GetComponent<TMP_Text>();
            nameText.text = name.ToString();

            priceText = gameObject.transform.Find("Button").gameObject.transform.GetChild(0).GetComponent<TMP_Text>();
            if (priceText != null)
            {
                priceText.text = price.ToString();
            }
        }
    }

    public void initializeForWardrobe()
    {
        if (mItemState != state.inWardRobe)
            return;
        Instantiate(Resources.Load("Buttons") as GameObject, gameObject.transform);
        if(gameObject.transform.Find("Button").transform.gameObject != null)
        {
            Destroy(gameObject.transform.Find("Button").transform.gameObject);
        }
    }
}
