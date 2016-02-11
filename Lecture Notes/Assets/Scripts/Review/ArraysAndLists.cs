using UnityEngine; //needed to make visible in the editor as a component.
using System.Collections; //needed to use monobehavior
using System.Collections.Generic; //needed for lists

public class ArraysAndLists : MonoBehaviour { //neede to use the start function

	//visible in the editor;
	public int[] myNums;

	public List<int> myListNums;

		//to make a list dynamic in unity
		void Start () {
		myListNums = new List<int> ();//use "new" infrequently
		//newing up the list makes it changeable to a script
		myListNums.Add (9); //this adds to the list
	}
}
