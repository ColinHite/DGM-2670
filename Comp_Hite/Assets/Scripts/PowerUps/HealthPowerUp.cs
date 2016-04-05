using UnityEngine;
using System.Collections;

public class HealthPowerUp : PowerUpPass
{

	public float healthAmount;
	
	void OnTriggerEnter () 
	{
		PowerUp (healthAmount = healthAmount + (healthAmount * 0.25f));

		if (GameObject.FindGameObjectWithTag("Player")) 
		{
			Destroy (gameObject);
			Debug.Log ("Is seeing player");
		}
	}
}
