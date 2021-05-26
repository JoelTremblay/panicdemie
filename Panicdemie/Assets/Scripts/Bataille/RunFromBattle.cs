using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RunFromBattle : MonoBehaviour {

	[SerializeField]
	private float runnningChance;

	public GameObject sonPrefab;

	public void tryRunning() {
		float randomNumber = Random.value;
		if (randomNumber < this.runnningChance) 
		{
			Destroy(GameObject.Find("sceneBataille"));
			Instantiate(sonPrefab);
			marchand.frozen = false;
			if (GameObject.Find("ennemi") != null) 
			{
				GameObject.Find("ennemi").GetComponent<SpawnEnemy>().enabled = true;
			}
		} 
		else 
		{
			GameObject.Find("TurnSystem").GetComponent<TurnSystem> ().nextTurn ();
		}
	}
}
