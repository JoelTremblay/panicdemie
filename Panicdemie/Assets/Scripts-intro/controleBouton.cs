using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controleBouton : MonoBehaviour
{
    public void OnStartGame(string sceneName)//clique sur le boutton jouer
    {
        SceneManager.LoadScene(sceneName);
    }


    public void ClickInstruction() //afficher texte
    {
       gameObject.SetActive(true);
    }

    public void AffichageButton()
    {
        gameObject.SetActive(false);
    }
}
