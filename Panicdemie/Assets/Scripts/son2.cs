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


    public static son2 Instance { get; set; }//单例

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            Destroy(gameObject);
        }

    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

    }


}
