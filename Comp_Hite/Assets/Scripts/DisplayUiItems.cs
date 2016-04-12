using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayUiItems : MonoBehaviour {

	public Text healthDisplay;

	void Start () 
	{
		healthDisplay = GetComponent <Text> ();
	}
	

	void Update () 
	{
		healthDisplay.text = "Hull Integrity: " + StaticVariables.playerHealth;
	}
}
