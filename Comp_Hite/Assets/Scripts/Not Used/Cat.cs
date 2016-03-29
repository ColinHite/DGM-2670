using UnityEngine;
using System.Collections;

public class Cat : AnimalInheritance {

	protected void Scratch ()
	{

		print ("scratching");
		//this can attack mice and break down chairs


	}

	void Start () 
	{
		Eat ();
	}
	
	void OnMouseDown () 
	{
		Scratch ();
	}
}
