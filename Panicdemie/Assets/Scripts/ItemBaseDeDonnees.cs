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
            new Item(1, "Livre", "description", 5, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(2, "Parapluie", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(3, "Gants", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(4, "Purell", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(5, "MasqueTissu", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(6, "MasqueMedical", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            }),
            new Item(7, "MasqueN95", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 15},
                {"Défense", 10}
            })
        };
    }
}
