using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Création de la classe constructeur Item.
 * Par : Joël Tremblay
*/
[System.Serializable]
public class Item
{
    public int id;
    public string titre;
    public string description;
    public int prix;
    public int currentStack;
    public int maxStack;
    public Sprite icone;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string titre, string description, int prix, int currentStack, int maxStack, Dictionary<string,int> stats)
    {
        this.id = id;
        this.titre = titre;
        this.description = description;
        this.prix = prix;
        this.currentStack = currentStack;
        this.maxStack = maxStack;
        this.icone = Resources.Load<Sprite>("Sprites/Items/" + titre);
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.titre = item.titre;
        this.description = item.description;
        this.prix = item.prix;
        this.currentStack = item.currentStack;
        this.maxStack = item.maxStack;
        this.icone = Resources.Load<Sprite>("Sprites/Items/" + item.titre);
        this.stats = item.stats;
    }
}
