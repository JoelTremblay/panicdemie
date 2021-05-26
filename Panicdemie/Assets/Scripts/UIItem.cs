using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/* Affichage des items, gestion du drag and drop et affichage de l'infobulle.
 * Par : Joël Tremblay
*/
public class UIItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private Image imageSprite;
    private Text itemStack;
    private Text stack;
    private UIItem itemSelection;
    private infoBulle infobulle;

    public static bool obj1;
    public static bool obj2;
    public static bool obj3;
    public static bool obj4;
    public static bool obj5;

    private void Awake()
    {
        imageSprite = GetComponent<Image>();
        itemStack = GetComponentInChildren<Text>();
        updateItem(null);
        itemSelection = GameObject.Find("itemSelection").GetComponent<UIItem>();
        infobulle = GameObject.Find("infoBulle").GetComponent<infoBulle>();

        obj1 = false;
        obj2 = false;
        obj3 = false;
        obj4 = false;
        obj5 = false;
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
            if (this.item.id == 0)
            {
                this.item = null;
                if (itemSelection.item.id == 0)
                {
                    itemSelection.item = null;
                }
            }
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

    public void utiliserItem()
    {
        if(itemSelection.item.titre == "Livre")
        {
            livre();
        }
        else if(itemSelection.item.titre == "Parapluie")
        {
            parapluie();
        }
        else if(itemSelection.item.titre == "Gants")
        {
            gants();
        }
        else if(itemSelection.item.titre == "Masque Tissu")
        {
            masqueTissu();
        }
        else if(itemSelection.item.titre == "Masque Medical")
        {
            masqueMedical();
        }
        else if(itemSelection.item.titre == "Masque N95")
        {
            masqueN95();
        }
    }

    public void livre()//
    {
        if (obj2 == true)
        {
            obj2 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 5;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense -= 7;
        }
        obj1 = true;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic += 5;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 5;
    }

    public void parapluie()//
    {
        if (obj1 == true)
        {
            obj1 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 5;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense -= 5;
        }
        obj2 = true;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic += 5;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 7;
    }

    public void gants()//
    {
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 5;
    }

    public void masqueTissu()
    {
        if (obj4 == true)
        {
            obj4 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 7;
        }
        else if (obj5 == true)
        {
            obj5 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 10;
        }
        obj3 = true;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 5;
    }

    public void masqueMedical()
    {
        if (obj3 == true)
        {
            obj3 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 5;
        }
        else if (obj5 == true)
        {
            obj5 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 10;
        }
        obj4 = true;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 7;
    }

    public void masqueN95()
    {
        if (obj3 == true)
        {
            obj3 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 5;
        }
        else if (obj4 == true)
        {
            obj4 = false;
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().magic -= 7;
        }
        obj5 = true;
        GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().defense += 10;
    }
}