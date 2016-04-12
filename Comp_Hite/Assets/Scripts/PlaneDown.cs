using UnityEngine;
using System.Collections;

	public class PlaneDown : MonoBehaviour {

	private PlaneFly player;

	private float delay = 1.0f;

	void Start ()
	{
		player = FindObjectOfType<PlaneFly> ();

	}

	public void PlayerIsDown ()
	{
		StartCoroutine ("KillPlayerCo");
	}

	public IEnumerator KillPlayerCo()
	{

			player.GetComponent<Rigidbody>().useGravity = true;
		yield return new WaitForSeconds (delay);
	}
}
