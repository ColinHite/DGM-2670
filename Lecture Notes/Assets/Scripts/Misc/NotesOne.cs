using UnityEngine;
using System.Collections;

public class NotesOne : MonoBehaviour {

	Rigidbody thisRigidBody;

	public float speed = 100f;

	void Start ()
	{
		thisRigidBody = GetComponent<Rigidbody> ();
	}

	void OnMouseDrag()
	{
		//this moves the position but is not working with the rigidbody.
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePosition.z = 0;
		Vector3 currentPosition = Vector3.Lerp(transform.position, mousePosition, speed*Time.deltaTime);
		thisRigidBody.MovePosition (currentPosition);
	}

	void OnMouseDown()
	{
		print ("Down");
		thisRigidBody.AddForce (0, 1000, 0);
	}

	void OnMouseEnter()
	{
		print ("Enter");
	}

	void OnMouseExit()
	{
		print ("Exit");
	}

}
