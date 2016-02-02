using UnityEngine;
using System.Collections;

public class ControlEvent : MonoBehaviour {

	public float distance = 1;

	public delegate void Control(float _distance);
	public static event Control OnControl;

	void Start () 
	{
		if(OnControl != null)
		OnControl (distance);
	}

	void OnMouseEnter ()
	{
		if(OnControl != null)
			OnControl (distance);
	}

}
