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

public int TotalTime = 30;//total90
public Text TimeText;//UI

private int minute;//minute
private int second;//second

public string LoadsceneName;// changement scene



    void Start() { 
        StartCoroutine(startTime());   //start
    }
    public IEnumerator startTime() { 
        while (TotalTime >= 0) { 
            //Debug.Log(TotalTime);
            yield return new WaitForSeconds(1);//start après 1 seconde timer -1
                                               
            TotalTime--;
            TimeText.text="Time:"+TotalTime;
            if (TotalTime == 0) //time = 0
            {
                Destroy(gameObject);
                LoadScene();
            }

            if (TotalTime > 0 && compteur.Score2 == 5)
            {
                Destroy(gameObject);
                LoadScene();
            }

            minute =TotalTime/60; //minute
            second =TotalTime%60; //second
            string length = minute.ToString();

            if (second >= 10) { 
                    TimeText.text = "0" + minute + ":" + second;
            }     //if second > 10         00：00
            else
                    TimeText.text = "0" + minute + ":0" + second;      //if second < 10   00：00
        }
    }

    void LoadScene() 
    {
        SceneManager.LoadScene(LoadsceneName);//lodingScene,LoadsceneName
    }
}
