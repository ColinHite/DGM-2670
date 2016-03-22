using UnityEngine;
using System.Collections;

public class PlayerCont : MonoBehaviour {

	private CharacterController player;
	private Vector3 forceCharacter = Vector3.zero;
	private float speed =5;

	private Vector3 moveDistance;

	void Start () 
	{
		player = GetComponent<CharacterController> ();
	}

	void Update () 
	{
		//GetComponent<CharacterController> ().velocity = new Vector2 (speed, GetComponent<CharacterController> ().velocity.z);
	}
}
