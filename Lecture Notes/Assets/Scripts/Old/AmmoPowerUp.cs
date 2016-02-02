using UnityEngine;
using System.Collections;

public class AmmoPowerUp : PowerUpOverloaded {

	public int ammoAmount = 10;

	public virtual void OnTriggerEnter ()
	{
		PowerUp (ammoAmount);
		print (StaticVariables.playerAmmo);
		print (StaticVariables.playerHealth);
	}

}
