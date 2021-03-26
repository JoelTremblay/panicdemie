using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    public GameObject ingameMenu;

    public void OnPause(){ // BOUTON = PAUSE
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnResume(){ // BOUTON = JOUER
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }

    public void OnRestart(){ // BOUTON = RESTART
        //Loading Scene3
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

}
