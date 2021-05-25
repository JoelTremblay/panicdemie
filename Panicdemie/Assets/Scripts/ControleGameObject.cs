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
  private AudioSource music;

     void Start()
    {
        music = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        compteur.Score = compteur.Score + 10;
        compteur.Score2 = compteur.Score2 +1;
        music.Play();


        Destroy(this.gameObject);
       
    }

}
