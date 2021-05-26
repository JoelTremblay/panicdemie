using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* Gestion de l'inventaire et gestion des stacks pour les objets.
 * Par : Joël Tremblay
*/
public class Inventaire : MonoBehaviour
{
    public List<Item> itemsPersonnage = new List<Item>();
    public ItemBaseDeDonnees itemBaseDeDonnees;
    public UIInventaire inventaireUI;
    public UIInventaire inventaireUIMarchand;
    public GameObject texteMarchand;
    public Text compteurArgent;

    // Start is called before the first frame update
    void Start()
    {
            donnerItemMarchand(1);
            donnerItemMarchand(2);
            donnerItemMarchand(3);
            donnerItemMarchand(4);
            donnerItemMarchand(5);
            donnerItemMarchand(6);
            donnerItemMarchand(7);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (marchand.frozen == false)
                {
                    inventaireUI.gameObject.SetActive(!inventaireUI.gameObject.activeSelf);
                    marchand.frozen = true;
                    if (marchand.inTrigger == true)
                    {
                        texteMarchand.SetActive(false);
                    }
                }
            else 
                {
                    inventaireUI.gameObject.SetActive(!inventaireUI.gameObject.activeSelf);
                    marchand.frozen = false;
                    if (marchand.inTrigger == true)
                    {
                        texteMarchand.SetActive(true);
                    }
                }
        }
        //Test
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    stackItem(1);
        //}
        //Test
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    stackItem(2);
        //}
        //Test
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    enleverItem(1);
        //}
        //Test
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    enleverItem(2);
        //}
    }

    public void donnerItem(int id)
    {
        Item itemAjouter = itemBaseDeDonnees.ChercherItem(id);
        if (itemAjouter.prix <= persoPrincipal.compteur)
                    {
                        persoPrincipal.compteur = persoPrincipal.compteur - itemAjouter.prix;
                        compteurArgent.text=""+ persoPrincipal.compteur;
                        itemsPersonnage.Add(itemAjouter);
                        inventaireUI.ajouterItem(itemAjouter);
                    }
    }

    public void donnerItem(string nomItem)
    {
        Item itemAjouter = itemBaseDeDonnees.ChercherItem(nomItem);
        itemsPersonnage.Add(itemAjouter);
        inventaireUI.ajouterItem(itemAjouter);
    }

    public void donnerItemMarchand(int id)
    {
        Item itemAjouter = itemBaseDeDonnees.ChercherItem(id);
        inventaireUIMarchand.ajouterItemMarchand(itemAjouter);
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
        Debug.Log(persoPrincipal.compteur);
        if (itemVerifier != null)
        {
            if (itemVerifier.currentStack < itemVerifier.maxStack)
                {
                    if (itemVerifier.prix <= persoPrincipal.compteur)
                    {
                        persoPrincipal.compteur = persoPrincipal.compteur - itemVerifier.prix;
                        compteurArgent.text=""+ persoPrincipal.compteur;
                        itemVerifier.currentStack++;
                        inventaireUI.positionItem(itemVerifier);
                    }
                }
        }
        else
        {
            donnerItem(id);
        }
    }

    public void purell()//
    {
        Item itemVerifier = verifierItem(4);
        if (itemVerifier != null && GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().health < 100)
        {
            GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().health += 20;
            if (GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().health > 100)
            {
                GameObject.FindWithTag("PlayerUnit").GetComponent<UnitStats>().health = 100;
            }
            enleverItem(4);
        }
    }
}