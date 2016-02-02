using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class MessagesPowerUp : PowerUpBase {

	public List<string> messages;
	public static Action<string> SendThisMessage;

	public override void OnTriggerEnter ()
	{
		base.OnTriggerEnter ();

		if (i < messages.Count) {
			if(SendThisMessage != null)
				SendThisMessage(messages[i]);
			i++;
		}

	}


}
