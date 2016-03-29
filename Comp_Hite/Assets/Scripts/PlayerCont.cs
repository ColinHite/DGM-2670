using UnityEngine;
using System.Collections;

public class PlayerCont : MonoBehaviour {

	public float speed =5;
	private float playerSpeed;

	void Start () 
	{
		playerSpeed = GetComponent<Rigidbody> ().velocity.x;
	}

	void Update () 
	{

		GetComponent<Rigidbody>().velocity = new Vector3 (playerSpeed, 0, speed);
	}
}
