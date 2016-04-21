using UnityEngine;
using System.Collections;

public class RotateHealth : MonoBehaviour {

	public Transform[] healthSpin;


	void Update () 
	{
	foreach (Transform health in healthSpin) 
		{
			health.Rotate(0,1,0);
		}
	}
}
