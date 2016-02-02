using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{

	public Transform[] cubes;

	void Start () 
	{
	
	}
	

	void Update () 
	{
//		for (int i = 0; i < cubes.Length; i++)
//		{
//			cubes [i].Rotate (0, 1, 0);
//		}

		foreach (Transform cube in cubes) 
		{
			cube.Rotate(0,1,0);
		}
	}
}
