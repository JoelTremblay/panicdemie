using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Contrôle Scene
 * Par : Feng Jiayi
 */


public class ButtonPause : MonoBehaviour
{
    public GameObject ingameMenu;

    public void OnPause(){ // BOUTON = PAUSE
        marchand.frozen = true;
        ingameMenu.SetActive(true);
    }

    public void OnResume(){ // BOUTON = CONTINUER
        marchand.frozen = false;
        ingameMenu.SetActive(false);
    }

    public void OnRestart(){ // BOUTON = RESTART
        //Loading Scene4 = seceneIntro
        marchand.frozen = false;
        compteur.Score = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
