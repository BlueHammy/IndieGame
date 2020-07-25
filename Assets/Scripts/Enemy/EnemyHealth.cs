using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;   
	public int currentHealth;                       
	public int playerKills = 1;        
	CapsuleCollider capsuleCollider;        
	bool isDead;                                          

	void Awake ()
	{
		capsuleCollider = GetComponent <CapsuleCollider> ();
		currentHealth = startingHealth;
	}
		

	public void TakeDamage (int amount)
	{
		if(isDead)
			return;
		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			Death ();
			Destroy (gameObject, 2f);
			PlayerKillCount.playerKills += playerKills;
		}
	}


	void Death ()
	{
		isDead = true;
		capsuleCollider.isTrigger = true;
	}
		
}