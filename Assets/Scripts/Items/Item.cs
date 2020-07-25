using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
	int getDamage = Ball.damage;
	int newDamage = 300;
	void OnTriggerEnter (Collider coll)
	{

		if(coll.gameObject.tag == "Player")
		{
			Ball.damage = newDamage;
			Debug.Log("DAMAGE UP");
			Destroy (GameObject.FindWithTag("Item"));
		}
	}
}