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
            new Item(1, "Livre", "description", 20, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 5},
                {"Défense", 5}
            }),
            new Item(2, "Parapluie", "description", 40, 1, 1,
            new Dictionary<string, int>
            {
                {"Force", 5},
                {"Défense", 7}
            }),
            new Item(3, "Gants", "description", 15, 1, 1,
            new Dictionary<string, int>
            {
                {"Défense", 5}
            }),
            new Item(4, "Purell", "description", 25, 1, 10,
            new Dictionary<string, int>
            {
                {"Soin", 20}
            }),
            new Item(5, "Masque Tissu", "description", 30, 1, 1,
            new Dictionary<string, int>
            {
                {"Défense", 5}
            }),
            new Item(6, "Masque Medical", "description", 50, 1, 1,
            new Dictionary<string, int>
            {
                {"Défense", 7}
            }),
            new Item(7, "Masque N95", "description", 70, 1, 1,
            new Dictionary<string, int>
            {
                {"Défense", 10}
            })
        };
    }

}
