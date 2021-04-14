using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class son : MonoBehaviour
{
  

    void Awake()
    {
       if(SceneManager.GetActiveScene().name != "MainScene")
        {
            DontDestroyOnLoad(this.gameObject);//ne destroy pas     
        }
        else
        {
            Destroy(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
