using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	//public ia accessable in the Unity Editor and other scripts.
	public int myInt = 0;
	//Private is not accessable in other scripts or unity editor.
	private string myString;
	//Also private
	int privateInt;

	//Other common data types
	public float myFloat;
	public Vector3 myVector3;

	//Other common for untiy
	public Transform myTransform;
	public GameObject myGameObject;

	void Start () {
		myTransform = GetComponent<Transform> ();
	}

	//this class can be used as a compnent or instance
	//static variables cant be instanced 

}

public class StaticVariabless 
{

	//static vars are accessed directly to a script
	//they are not instanced or used as a unity component
	//static vars must be public 
	public static int staticInt = 10;
	public static string staticString = "dog";
	//to use "GameObject" you must use "using UnityEngine"
	public static GameObject staticGameObject;


}
