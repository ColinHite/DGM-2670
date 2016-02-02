using UnityEngine;
using System.Collections;

public class HealthPowerUp : PowerUpOverloaded {
	
	public float healthAmount = 0.1f;
	
	void OnTriggerEnter ()
	{
		print (StaticVariables.playerAmmo);
		print (StaticVariables.playerHealth);
		PowerUp (healthAmount);
		print (StaticVariables.playerAmmo);
		print (StaticVariables.playerHealth);
	}

}
