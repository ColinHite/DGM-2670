using UnityEngine;
using System.Collections;
using System;

public class SetThisAsSpawnPoint : MonoBehaviour {

	public static Action<Transform> PassTransformAsSpawnPoint;

	// Use this for initialization
	void Start () 
	{
	if (PassTransformAsSpawnPoint != null)
			PassTransformAsSpawnPoint (transform);
	}
	
}
