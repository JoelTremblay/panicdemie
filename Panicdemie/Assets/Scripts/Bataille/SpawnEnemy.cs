using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	[SerializeField]
	private GameObject enemyEncounterPrefab;

	private static GameObject instance;

	public bool spawning = false;

	void Start() {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		if (scene.name == "Battle") {
			if (this.spawning == true) {
				Instantiate (enemyEncounterPrefab);
			}
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			this.spawning = true;
			//GameObject.Find("ambiance2").SetActive(false);
			SceneManager.LoadScene ("Battle");
		}
	}
}
