using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToLevels : MonoBehaviour {

	void OnCollisionEnter(Collision room) {
		if (room.gameObject.tag == "Player")
		{
			Application.LoadLevel ("newScene");
		}
	}
}
