using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* Gestion des déplacements et collisions de LILO
 * Par : ANGÉLICA Montufar
 * Dernière modif : 14 avril 2021
 * Illustations fait par Angélica MM et Script
 */

public class intro1 : MonoBehaviour
{
   public void OnStartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
        if(sceneName == "Scene")
        {
            Destroy(GameObject.Find("son"));
        }
        
    }


}
