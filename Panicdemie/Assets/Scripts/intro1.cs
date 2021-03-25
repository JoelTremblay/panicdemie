using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro1 : MonoBehaviour
{
   public void OnStartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void click()
    {
        gameObject.SetActive(false);
        
    }
}
