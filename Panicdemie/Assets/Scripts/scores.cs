using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    public Text objetsTrouves;
    public Text objetsPoints;
    public Text ennemisTues;
    public Text argentRestant;

    // Update is called once per frame
    void Update()
    {
        objetsTrouves.text = "Objets trouvés: " + persoPrincipal.compteurObjets + "/10";

        objetsPoints.text = "Points obtenus: " + compteur.Score;

        ennemisTues.text = "Ennemis vaincus: " + persoPrincipal.compteurEnnemis;

        argentRestant.text = "Argent restant: " + persoPrincipal.compteur + " $";
    }
}