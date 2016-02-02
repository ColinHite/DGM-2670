using UnityEngine;
using System.Collections;

public class EventHandlerSphere : MonoBehaviour {

	Vector3 newDistance;

	void Start () 
	{
	ControlEvent.OnControl += HandleOnControl;
	}

	void HandleOnControl (float _distance)
	{
		for (int i = 0; i < 3; i++) 
		{

			newDistance[i] += _distance;

		}
		transform.localScale = newDistance;
	}

}
