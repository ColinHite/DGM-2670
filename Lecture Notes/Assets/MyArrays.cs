using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyArrays : MonoBehaviour {

	public List<string> myStringList;

	void OnTriggerEnter (Collider _c)
	{
		myStringList.Add (_c.gameObject.name);
		_c.gameObject.SetActive (false);
	}

	void Start () 
	{
		myStringList = new List<string> ();
	}
	
}
