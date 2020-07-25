using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public static int startingHealth = 100;                            
	public int currentHealth;                                   
	public Slider healthSlider;                                
	public Image damageInidicator;                            
	public float flashSpeed = 5f;                              
	public Color flashColour = new Color(5f, 0f, 0f, 0.1f);    
	PlayerMovement playerMovement;                             
	bool isDead;                                              
	bool damaged;                                              


	void Awake ()
	{
		playerMovement = GetComponent <PlayerMovement> ();
		currentHealth = startingHealth;
	}


	void Update ()
	{

		if(damaged)
		{
	
			damageInidicator.color = flashColour;
		}

		else
		{
			damageInidicator.color = Color.Lerp (damageInidicator.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}


	public void TakeDamage (int amount)
	{
		damaged = true;
		healthSlider.value = currentHealth;
		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;
		playerMovement.enabled = false;
		Application.LoadLevel ("mainMenu");
	}       
}