using UnityEngine;
using System.Collections;

public class AnimalInheritance : MonoBehaviour {

	public int energy = 100;
	public int health = 100;
	public int points = 0;

	protected void Start ()
	{
		Eat ();
		//OnPlay.CallPlay += Play;
	}

	protected void Eat () 
	{
		print (this.name + " is eating");
		//process food
	}
	
	protected void Sleep () 
	{
		//run calc sleeping * energy
	}

	protected void Play () 
	{

		print (this.name + " is playing");
		//subtract energy add points
	}
}
