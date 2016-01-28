using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

	void Start () 
	{
	ControlEvent.OnControl += HandleOnControl;
	}

	void HandleOnControl (float _distance)
	{
		transform.Rotate (0, 0, _distance);
	}
}
