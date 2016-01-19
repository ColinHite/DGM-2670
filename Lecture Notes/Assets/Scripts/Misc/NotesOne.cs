using UnityEngine;
using System.Collections;

public class NotesOne : MonoBehaviour {

	Rigidbody thisRigidBody;

	void Start ()
	{
		thisRigidBody = GetComponent<Rigidbody> ();
	}

	void OnMouseDown()
	{
		print ("Down");
		thisRigidBody.AddForce (0, 1000, 0);
	}
	void OnMouseEnter()
	{
		print ("Enter");
	}void OnMouseDrag()
	{
		print ("Drag");
	}void OnMouseExit()
	{
		print ("Exit");
	}

}
