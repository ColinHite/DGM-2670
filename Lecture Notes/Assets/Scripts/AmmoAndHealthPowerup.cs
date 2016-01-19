using UnityEngine;
using System.Collections;

public class AmmoAndHealthPowerup : AmmoPowerUp {

	public float healthAmount = 0.1f;

	public override void OnTriggerEnter ()
	{
		base.OnTriggerEnter ();
		PowerUp (healthAmount);
	}

}
