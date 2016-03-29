using UnityEngine;
using System.Collections;

public class Dog : AnimalInheritance {

	void Bark()
	{
		print ("barking");
		//This can scare cats away

	}

	void OnMouseDown () 
	{
		Play ();
	}
}
