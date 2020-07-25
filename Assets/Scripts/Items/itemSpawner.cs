using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour {
	public GameObject Item;
	public GameObject Item1;
	int whatSpawns;


	// Update is called once per frame
	void Start () {

			
			whatSpawns = Random.Range (1, 3);

			switch (whatSpawns) {
			case 1:
				Instantiate (Item, transform.position, Quaternion.identity);
				break;
			case 2:
				Instantiate (Item1, transform.position, Quaternion.identity);
				break;
			}

		}
	}

