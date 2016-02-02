using UnityEngine;
using System.Collections;

public class MessagePowerUp : PowerUpOverloaded{

	public string[] newMessages;

	int i = 0;

	void OnTriggerEnter()
	{
		if (i < newMessages.Length) {
			PowerUp (newMessages [i]);
			i++;
		} else {

			gameObject.SetActive(false);

		}
	}

}
