using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Contrôle points
 * Par : Feng Jiayi
 */

public class ControleGameObject : MonoBehaviour
{
   
    void OnMouseDown()
    {
        compteur.Score = compteur.Score + 10;
        compteur.Score2 = compteur.Score2 + 1;

        persoPrincipal.compteurObjets = persoPrincipal.compteurObjets + 1;

        Destroy(this.gameObject);
    }

}
