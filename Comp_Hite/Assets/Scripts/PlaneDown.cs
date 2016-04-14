using UnityEngine;
using System.Collections;

	public class PlaneDown : MonoBehaviour {

	private PlaneFly player;

	private float delay = 1.0f;
    public float respawnDelay = 5.0f;

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
        if (player.gameObject == false)
        {
            new WaitForSeconds (respawnDelay);
            player.gameObject.SetActive(true);
        }
			player.GetComponent<Rigidbody>().useGravity = true;
		yield return new WaitForSeconds (delay);
	}
}
