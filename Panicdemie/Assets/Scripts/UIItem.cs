using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private Image imageSprite;
    private Text itemStack;
    private Text stack;
    private UIItem itemSelection;
    private infoBulle infobulle;

    private void Awake()
    {
        imageSprite = GetComponent<Image>();
        itemStack = GetComponentInChildren<Text>();
        updateItem(null);
        itemSelection = GameObject.Find("itemSelection").GetComponent<UIItem>();
        infobulle = GameObject.Find("infoBulle").GetComponent<infoBulle>();
    }

    public void updateItem(Item item)
    {
        this.item = item;
        if (this.item != null)
        {
            imageSprite.color = Color.white;
            imageSprite.sprite = this.item.icone;
            itemStack.text = "x" + this.item.currentStack.ToString();
        }
        else
        {
            imageSprite.color = Color.clear;
            itemStack.text = "";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.item != null)
        {
            if (itemSelection.item != null)
            {
                Item clone = new Item(itemSelection.item);
                itemSelection.updateItem(this.item);
                updateItem(clone);
            }
            else
            {
                itemSelection.updateItem(this.item);
                updateItem(null);         
            }
        }
        else if (itemSelection.item != null)
        {
            updateItem(itemSelection.item);
            itemSelection.updateItem(null);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (this.item != null)
        {
            infobulle.genererInfoBulle(this.item);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        infobulle.gameObject.SetActive(false);
    }
}
