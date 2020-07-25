using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Rigidbody rb;
	float timePressed = 0f;
	public static int damage = 30;

	void OnTriggerEnter (Collider col)
	{
		

		if(col.gameObject.tag == "Enemy")
		{
			EnemyHealth enemyHealth = col.GetComponent<Collider>().GetComponent <EnemyHealth> ();

			if(enemyHealth != null)
			{
				enemyHealth.TakeDamage (damage);
				rb.transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position;
				rb.velocity = new Vector3 (0, 0, 0);
			}
		}
		if (col.gameObject.tag == "Wall" || col.gameObject.tag == "Door")
		{
			rb.transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
		}
	
	}


	void Update()
	{

		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = new Vector3 (0, 0, 0);

			timePressed = Time.time;

			}
		if (Input.GetMouseButtonUp (0)) {
			timePressed = Time.time - timePressed;
		
			fire ();

		}
		if (Input.GetKeyDown ("r")) {
			rb.transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position;
			rb.velocity = new Vector3 (0, 0, 0);
		}
		if (Input.GetKeyDown ("m")) 
		{
			Application.LoadLevel ("mainMenu");
		}

		}
	void fire()
	{
		if (timePressed > 0) 
		{
			rb.velocity = new Vector3 (0, 0, 0);
			if (timePressed > 0.5) 
			{
				rb.velocity = new Vector3 (5, 0, 0);
				if (timePressed > 1) 
				{
					rb.velocity = new Vector3 (10, 0, 0);
				}
			}
		}
	}

}