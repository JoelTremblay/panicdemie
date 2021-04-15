using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Gestion de l'inventaire et gestion des stacks pour les objets.
 * Par : Joël Tremblay
*/
public class Inventaire : MonoBehaviour
{
    public List<Item> itemsPersonnage = new List<Item>();
    public ItemBaseDeDonnees itemBaseDeDonnees;
    public UIInventaire inventaireUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventaireUI.gameObject.SetActive(!inventaireUI.gameObject.activeSelf);
        }
        //Test
        if (Input.GetKeyDown(KeyCode.O))
        {
            stackItem(1);
        }
        //Test
        if (Input.GetKeyDown(KeyCode.P))
        {
            stackItem(2);
        }
        //Test
        if (Input.GetKeyDown(KeyCode.K))
        {
            enleverItem(1);
        }
        //Test
        if (Input.GetKeyDown(KeyCode.L))
        {
            enleverItem(2);
        }
    }

    public void donnerItem(int id)
    {
        Item itemAjouter = itemBaseDeDonnees.ChercherItem(id);
        itemsPersonnage.Add(itemAjouter);
        inventaireUI.ajouterItem(itemAjouter);
    }

    public void donnerItem(string nomItem)
    {
        Item itemAjouter = itemBaseDeDonnees.ChercherItem(nomItem);
        itemsPersonnage.Add(itemAjouter);
        inventaireUI.ajouterItem(itemAjouter);
    }

    public Item verifierItem(int id)
    {
        return itemsPersonnage.Find(item => item.id == id);
    }

    public void enleverItem(int id)
    {
        Item itemEnlever = verifierItem(id);

        if (itemEnlever != null)
        {
            if (itemEnlever.currentStack > 1)
                {
                    itemEnlever.currentStack--;
                    inventaireUI.positionItem(itemEnlever);
                }
            else 
            {
                itemsPersonnage.Remove(itemEnlever);
                inventaireUI.retirerItem(itemEnlever);
            }
        }
    }

    public void stackItem(int id)
    {
        Item itemVerifier = verifierItem(id);

        if (itemVerifier != null)
        {
            if (itemVerifier.currentStack < itemVerifier.maxStack)
                {
                    itemVerifier.currentStack++;
                    inventaireUI.positionItem(itemVerifier);
                }
        }
        else
        {
            donnerItem(id);
        }
    }
}