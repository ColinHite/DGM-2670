using UnityEngine;
using System.Collections;

public class PlayerContBackup : MonoBehaviour {

    //Air Plane pos / mouse pos
    public Transform airPlanePos;
    //public Transform mousePos;

    //AirPlane speed controls
	public float speed =5;
	private float playerSpeed;

	void Start ()
    { 
		playerSpeed = GetComponent<Rigidbody> ().velocity.x;
	}

	void Update () 
	{

        //transform.localPosition = Vector3.Lerp (airPlanePos.position, Input.mousePosition, Time.time);

        GetComponent<Rigidbody>().velocity = new Vector3 (playerSpeed, 0, speed);
	}
}
