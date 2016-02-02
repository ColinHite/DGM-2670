using UnityEngine;
using System.Collections;

public class EventHandlerCube : MonoBehaviour {

	Vector3 newPosition;

	void Start () {
	ControlEvent.OnControl += HandleOnControl;
	}

	void HandleOnControl (float _distance)
	{
		newPosition.y += _distance;
		transform.localPosition = newPosition;
	}

}
