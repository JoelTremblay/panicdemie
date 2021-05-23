using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Contrôle Time
 * Par : Feng Jiayi
 */



public class timer : MonoBehaviour {

public int TotalTime = 90;//total
public Text TimeText;//UI

private int mumite;//mumite
private int second;//second

public string LoadsceneName;// changement scene
public string LoadsceneName2;



    void Start() { 
        StartCoroutine(startTime());   //start
    }
    public IEnumerator startTime() { 
        while (TotalTime >= 0) { 
            //Debug.Log(TotalTime);
            yield return new WaitForSeconds(1);//start après 1 seconde timer -1
                                               
            TotalTime--;
            TimeText.text="Time:"+TotalTime;
            if (TotalTime == 0 && compteur.Score == 50) //time = 0
            {
                Destroy(gameObject);
                LoadScene();
            }

            if (TotalTime == 0 && compteur.Score < 50)
            {
                Destroy(gameObject);
                LoadScene2();
            }

            mumite =TotalTime/60; //mumite
            second =TotalTime%60; //second
            string length = mumite.ToString();

            if (second >= 10) { 
                    TimeText.text = "0" + mumite + ":" + second;
            }     //if second > 10         00：00
            else
                    TimeText.text = "0" + mumite + ":0" + second;      //if second < 10   00：00
        }
    }

    void LoadScene() {

        SceneManager.LoadScene(LoadsceneName);//lodingScene,LoadsceneName
    }

    void LoadScene2()
    {

        SceneManager.LoadScene(LoadsceneName2);//lodingScene,LoadsceneName
    }
}
