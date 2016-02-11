using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	void voidFunction () {//void is a function with no return value
		print (null);
	}

	void FunctionWithParameters (string _string){//_string is the paramerter
		print (_string);

	}

	int FunctionReturnsAnInt () {//when called this returns a value
		return 10;
	}

	int FunctionReturnsWithParameter (int _int){
		return _int + 10;//returns an equation
	}

	// Use this for initialization
	void Start () { //Unity MonoBehavior
		print ("Will run on Start");
		voidFunction ();
		FunctionWithParameters ("This is the String");
		int myInt = FunctionReturnsAnInt ();
		print (myInt);
		myInt = FunctionReturnsWithParameter (6);
		print (myInt);
	}
	
	// Update is called once per frame
	void Update () {//Unity MonoBehavior
		print ("Will rin on update");
	}
}
