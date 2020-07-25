using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
	public PlayerHealth playerHealth;       
	public GameObject Enemy;               
	public float timeBetweenSpawn = 3f;         
	public Transform[] spawnPoints;         


	void Start ()
	{
		InvokeRepeating ("Spawn", timeBetweenSpawn, timeBetweenSpawn);
	}


	void Spawn ()
	{
		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}