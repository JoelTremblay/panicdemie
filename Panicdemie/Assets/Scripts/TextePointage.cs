using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextePointage : MonoBehaviour
{

    public Text compteurArgent;
    public static int compteur = 0;

    // Start is called before the first frame update
    void Start()
    {
        compteur = 0;
    }

    // Update is called once per frame
    void Update()
    {
        compteurArgent.text = "Argent: " + compteur;

    }
}