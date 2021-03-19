using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleBouton : MonoBehaviour
{
    public void OnStartGame(string sceneName)//clique sur le boutton jouer
    {
        SceneManager.LoadScene(sceneName);
    }
}
