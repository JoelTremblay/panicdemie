using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Contrôle Score
 * Par : Feng Jiayi
 */



public class compteur : MonoBehaviour
{
    public static int Score = 0;
    public static int Score2 = 0;

    public Text ShowScore;
    public Text ShowScore2;

    void Start()
    {
        Score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore.text = Score.ToString();

        ShowScore2.text = Score2.ToString();
    }
}
