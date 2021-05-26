using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartBattle : MonoBehaviour {

	private static GameObject instance;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);

		SceneManager.sceneLoaded += OnSceneLoaded;

	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		if (scene.name == "Scene") 
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
			Destroy (this.gameObject);
		}
	}

}
