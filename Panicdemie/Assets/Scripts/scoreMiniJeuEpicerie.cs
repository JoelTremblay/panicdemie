using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreMiniJeuEpicerie : MonoBehaviour
{
    public Text objetsTrouves;
    public Text objetsPoints;

    // Update is called once per frame
    void Update()
    {
        objetsTrouves.text = "Objets trouvés: " + compteur.Score2 + "/5";
        objetsPoints.text = "Points obtenus: " + compteur.Score;
    }
}
