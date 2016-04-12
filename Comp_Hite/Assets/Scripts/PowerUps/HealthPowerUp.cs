using UnityEngine;
using System.Collections;

public class HealthPowerUp : PowerUpPass
{

	private float healthAmount;
	
	void OnTriggerEnter () 
	{
		PowerUp (healthAmount = (StaticVariables.playerHealth * 0.25f));

		

		Debug.Log ("This is adding health by: " + healthAmount);
		Debug.Log ("This should be the current health: " + StaticVariables.playerHealth);

		if (GameObject.FindGameObjectWithTag("Player")) 
		{
			Destroy (gameObject);
			Debug.Log ("Is seeing player");
		}

	}
}
