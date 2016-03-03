using UnityEngine;
using System.Collections;

public class PuzzelLogic : MonoBehaviour {

	public string[] logicOrder = new string[] {"red","green","blue"};
	public GameObject[] colorZones;

	public Animator animStates;

	public int i = 0;

public void RunLogic (string _color)
	{
		print (_color);

		if (_color != logicOrder[i]) 
			return;

		colorZones [i].SetActive (false);
		if (i < logicOrder.Length) {
			i++;
			print (i);
		}
		if(i == logicOrder.Length)
		animStates.SetBool ("CanOpen", true);
	}

}
