using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressForMenu : MonoBehaviour {


	void OnMouseUp()
	{
		Application.LoadLevel ("mainMenu");
	}
}
