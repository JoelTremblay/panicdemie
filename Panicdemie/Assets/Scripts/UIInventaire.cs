using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* Affichage des cases et méthodes pour l'affichage des items dans l'inventaire.
 * Par : Joël Tremblay
*/
public class UIInventaire : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public List<UIItemMarchand> uIItemsMarchand = new List<UIItemMarchand>();
    public GameObject casePrefab;
    public GameObject casePrefabMarchand;
    public Transform casePanel;
    public int nbDeCases;
    public Inventaire inventaire;

    private void Awake()
    {
        if (gameObject.name == "inventairePanel")
        {
            for (int i = 0; i < nbDeCases; i++)
            {
                GameObject instance = Instantiate(casePrefab);
                instance.transform.SetParent(casePanel);
                uIItems.Add(instance.GetComponentInChildren<UIItem>());
            }
        }
        else 
        {
            for (int i = 0; i < nbDeCases; i++)
            {
                GameObject instance = Instantiate(casePrefabMarchand);
                instance.transform.SetParent(casePanel);
                uIItemsMarchand.Add(instance.GetComponentInChildren<UIItemMarchand>());
            }
        }
    }

    public void updateCase(int caseItem, Item item)
    {
        uIItems[caseItem].updateItem(item);
    }

    public void updateCaseMarchand(int caseItem, Item item)
    {
        uIItemsMarchand[caseItem].updateItem(item);
    }

    public void ajouterItem(Item item)
    {
        updateCase(uIItems.FindIndex(i => i.item == null), item);
    }

    public void ajouterItemMarchand(Item item)
    {
        updateCaseMarchand(uIItemsMarchand.FindIndex(i => i.item == null), item);
    }

    public void retirerItem(Item item)
    {
        updateCase(uIItems.FindIndex(i => i.item == item), null);
    }

    public void positionItem(Item item)
    {
        updateCase(uIItems.FindIndex(i => i.item == item), item);
    }
}
