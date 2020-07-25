using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerKillCount : MonoBehaviour {

	public static int playerKills;
	Text text;

	void Awake ()
	{
		
		playerKills = 0;
		text = GetComponent <Text> ();

	}

	void Update () {
		
		text.text = "Kills: " + playerKills;
	
	}
}
