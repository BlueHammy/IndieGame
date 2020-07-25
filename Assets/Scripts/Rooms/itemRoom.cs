using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRoom : MonoBehaviour {
	PlayerKillCount playerKills;

	void Awake ()
	{
		playerKills = GetComponent <PlayerKillCount> ();
	}


	void OnCollisionEnter(Collision room) {
		if (room.gameObject.tag == "Player" && PlayerKillCount.playerKills > 10)
		{
			Application.LoadLevel ("itemRoom");
		}
	}
}