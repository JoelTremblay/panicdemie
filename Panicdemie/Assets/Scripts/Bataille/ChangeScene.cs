using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	public Text compteurArgent;

	public GameObject sonPrefab;

	public void loadNextScene(string sceneName) {
		SceneManager.LoadScene (sceneName);
	}

	public void verifierMontantPharmacie()
	{
		if (persoPrincipal.compteur > 50)
		{
			Destroy(GameObject.Find("police"));
			if (GameObject.Find("police") != null) 
			{
				GameObject.Find("police").GetComponent<police>().enabled = true;
			}
			Destroy(GameObject.Find("BlocageNiveau1"));
			persoPrincipal.compteur = persoPrincipal.compteur - 50;
			compteurArgent.text = "" + persoPrincipal.compteur;
			loadNextScene("introMiniJeuPharmacie");
		}
	}

	public void verifierMontantEpicerie()
	{
		if (persoPrincipal.compteur > 100)
		{
			Destroy(GameObject.Find("police"));
			Destroy(GameObject.Find("BlocageNiveau2"));
			persoPrincipal.compteur = persoPrincipal.compteur - 100;
			compteurArgent.text = "" + persoPrincipal.compteur;
			loadNextScene("introMiniJeuEpicerie");
		}
	}

	public void detruireSceneMiniJeu()
	{
		Destroy(GameObject.Find("miniJeu"));
		Instantiate(sonPrefab);
		marchand.frozen = false;
	}

	public void detruireSceneJeu()
	{
		Destroy(GameObject.Find("Scene"));
		loadNextScene("Scene");
		marchand.frozen = false;
		compteur.Score = 0;
	}
}
