using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youWin : MonoBehaviour {
	PlayerKillCount playerKills;

	void Awake ()
	{
		playerKills = GetComponent <PlayerKillCount> ();
	}


	void OnCollisionEnter(Collision room) {
		if (room.gameObject.tag == "Player" && PlayerKillCount.playerKills > 0)
		{
			Application.LoadLevel ("youWin");
		}
	}
}

