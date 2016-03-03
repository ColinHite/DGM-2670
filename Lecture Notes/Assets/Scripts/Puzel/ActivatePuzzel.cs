using UnityEngine;
using System.Collections;

public class ActivatePuzzel : MonoBehaviour {

	//public Animator anims;

	//public enum colors {green,red,blue}

	public PuzzelLogic colorPuzzelLogic;

	void OnTriggerEnter ()
	{
		colorPuzzelLogic.RunLogic (this.name);
		//anims.SetBool ("CanOpen", true);

	}
}
