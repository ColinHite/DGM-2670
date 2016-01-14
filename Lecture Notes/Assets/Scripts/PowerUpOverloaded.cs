using UnityEngine;
using System.Collections;

public class PowerUpOverloaded : MonoBehaviour {


	public void PowerUp (int ammo)
	{
		StaticVariables.playerAmmo += ammo;
	}

	public void PowerUp (float health)
	{
		StaticVariables.playerHealth += health;
	}
	public void PowerUp (string message)
	{
		print (message);
	}

}
