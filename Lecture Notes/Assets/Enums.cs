using UnityEngine;
using System.Collections;

public class Enums : MonoBehaviour {

	//This Script is to demonstrate enums and why not to use Update for different functions.


	//This allows for Garbage collection to be minimized so that the system doesn't collect usless data links. 
	//Instead this gives one reference piece of data. If its in the Update it still looks at it every frame however.
	public Vector3 myPosition;


	//enums collect tagged items.
/*	public enum myGameColors {
		Blue, Green, Red
	}
*/
	//public myGameColors myCurrentGameColor = myGameColors.Red;


	//void Update ()
	//{
		//If the system compared a new value to the position it creates a lot of unlinked values that makes a lot of garbadge dumping.
		//In this case it references only the one value "myPosition".
/*		Vector3 position = new Vector3 ();
		transform.position = myPosition;
*/

		//This is suposed to be better than useing a standard if statement becaue it only loads aplicable cases.
/*		switch (myCurrentGameColor) 
		{
		case myGameColors.Blue:
			print (myGameColors.Blue);
			break;
		case myGameColors.Red:
			print (myGameColors.Red);
			break;
		case myGameColors.Green:
				print (myGameColors.Green);
			break;
		default:
			print ("No Color");
			break;
		}


		switch (StaticVariables.CurrentWeapon) 
		{
		case myGameColors.Blue:
			print (myGameColors.Blue);
			break;
		case myGameColors.Red:
			print (myGameColors.Red);
			break;
		case myGameColors.Green:
			print (myGameColors.Green);
			break;
		default:
			print ("No Color");
			break;
	}
*/
	//This is a sollution to not having a value on Update. OnMouseDown Loads when the item is clicked. (maybe on the hitbox not sure though)
/*	void OnMouseDown () 
	{
		if (myCurrentGameColor == myGameColors.Red)
			print (myCurrentGameColor);
		else 
		{
			print ("isNotRed");
		}
	}*/
}

