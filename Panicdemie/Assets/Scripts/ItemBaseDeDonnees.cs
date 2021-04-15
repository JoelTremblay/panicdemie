using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Gestion de la base de données et méthodes pour chercher les objets.
 * Par : Joël Tremblay
*/
public class ItemBaseDeDonnees : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void  Awake()
    {
        CreerBaseDeDonnees();
    }

    public Item ChercherItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item ChercherItem(string nomItem)
    {
        return items.Find(item => item.titre == nomItem);
    }

    void CreerBaseDeDonnees()
    {
        items = new List<Item>()
        {
            new Item(1, "Parapluie", "description", 0, 1, 10,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(2, "Livre", "description", 0, 1, 10,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            })
        };
    }
}
