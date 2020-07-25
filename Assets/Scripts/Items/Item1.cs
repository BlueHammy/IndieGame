using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour {

	int getHealth = PlayerHealth.startingHealth;
	int newHealth = 1000;
	void OnTriggerEnter (Collider coll)
	{


		if(coll.gameObject.tag == "Player")
		{
			PlayerHealth.startingHealth = newHealth;
			Debug.Log("HEALTH UP");
			Destroy (GameObject.FindWithTag("Item"));
		}
	}
}