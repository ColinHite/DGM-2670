using UnityEngine;
using System.Collections;

public class MessageAndAmmoPU : MessagePowerUp {

	public override void OnTriggerEnter ()
	{
		base.OnTriggerEnter ();
		PowerUp (10);
		print (StaticVariables.playerAmmo);
	}

}
