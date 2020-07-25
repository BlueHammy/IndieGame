using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverOver : MonoBehaviour {
	Material material;
	void Start () {
		material = GetComponent<Renderer>().material;
	}
	void OnMouseOver()
	{
		material.color = Color.blue;
	}
	

	void OnMouseExit()
	{
		material.color = Color.green;
	}
}
