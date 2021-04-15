using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventaire : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public GameObject casePrefab;
    public Transform casePanel;
    public int nbDeCases = 6;
    public Inventaire inventaire;

    private void Awake()
    {
        for (int i = 0; i < nbDeCases; i++)
        {
            GameObject instance = Instantiate(casePrefab);
            instance.transform.SetParent(casePanel);
            uIItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    public void updateCase(int caseItem, Item item)
    {
        uIItems[caseItem].updateItem(item);
    }

    public void ajouterItem(Item item)
    {
        updateCase(uIItems.FindIndex(i => i.item == null), item);
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
