using UnityEngine;
using System.Collections;

public class GameOp : MonoBehaviour {

	public string GameLevel = "DogFighter_Hite";

	public void Play ()
	{
		Application.LoadLevel (GameLevel);
	}

}
