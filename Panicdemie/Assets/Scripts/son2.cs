using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Contrôle son
 * Par : Feng Jiayi
 */

public class son2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            gameObject.SetActive(false);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
