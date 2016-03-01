using UnityEngine;
using System.Collections;

public class ActivatePuzzel : MonoBehaviour {

	public Animator anims;

	public enum colors [green,red,blue]

	void OnTriggerEnter ()
	{

		anims.SetBool ("CanOpen", true);

	}
}
