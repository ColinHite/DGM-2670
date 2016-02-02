using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour {

	private Text displayText;

	void DisplayMessage (string _message)
	{
		displayText.text = _message;
	}

	void Start () {
		displayText = GetComponent<Text> ();
		MessagesPowerUp.SendThisMessage += DisplayMessage;
	}

}
