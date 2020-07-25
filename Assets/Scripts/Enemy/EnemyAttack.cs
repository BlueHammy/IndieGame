using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f; 
	public int damage = 5;          
	GameObject player;                     
	EnemyHealth enemyHealth;
	PlayerHealth playerHealth;                  
	float timeUntilNextAttack; 
	bool isPlayerInRange;


	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			isPlayerInRange = true;
		}
	}


	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == player)
		{
			isPlayerInRange = false;
		}
	}


	void Update ()
	{
		timeUntilNextAttack += Time.deltaTime;
		if(timeUntilNextAttack >= timeBetweenAttacks && isPlayerInRange && enemyHealth.currentHealth > 0)
		{
			Attack ();
		}
	}


	void Attack ()
	{
		timeUntilNextAttack = 0f;

		if(playerHealth.currentHealth > 0)
		{
			playerHealth.TakeDamage (damage);
		}
	}
}