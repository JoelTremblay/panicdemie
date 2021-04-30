using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* Création de l'infobulle pour les objets.
 * Par : Joël Tremblay
*/
public class infoBulle : MonoBehaviour
{
    private Text infobulle;
    // Start is called before the first frame update
    void Start()
    {
        infobulle = GetComponentInChildren<Text>();
        gameObject.SetActive(false);
    }

    public void genererInfoBulle(Item item)
    {
        string texteStats = "";
        if (item.stats.Count > 0)
        {
            foreach (var stat in item.stats)
            {
                texteStats += stat.Key.ToString() + ": " + stat.Value.ToString() + "\n";
            }
        }
        string texteinfobulle = string.Format("{0}\n{1}\n{2}\n{3}", item.titre, item.description, "Prix: " + item.prix, texteStats);
        infobulle.text = texteinfobulle;
        gameObject.SetActive(true);
    }
}
