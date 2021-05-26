using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectReward : MonoBehaviour {

	[SerializeField]
	private int recompense;

	public void Start() {
		GameObject turnSystem = GameObject.Find ("TurnSystem");
		turnSystem.GetComponent<TurnSystem> ().enemyEncounter = this.gameObject;
	}

	public void collectReward() 
	{
		persoPrincipal.compteur = persoPrincipal.compteur + recompense;
		Text compteurArgent = GameObject.Find("compteurArgent").GetComponent<Text>();
        compteurArgent.text=""+ persoPrincipal.compteur;

		Destroy (this.gameObject);
	}
}
