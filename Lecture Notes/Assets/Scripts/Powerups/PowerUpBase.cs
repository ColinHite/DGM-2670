using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour {

	public int i = 0;

	public virtual void OnTriggerEnter () 
	{
		print ("PowerUp");
	}

}
