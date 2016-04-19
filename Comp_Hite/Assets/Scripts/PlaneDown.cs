using UnityEngine;
using System;
using System.Collections;

	public class PlaneDown : MonoBehaviour {

	private PlaneFly player;

	private float delay = 1.0f;
    public float respawnDelay = 5.0f;

    public void PlayerIsDown(TerrainStuff _isDead)
    {
        StartCoroutine("KillPlayerCo");
    }


    void Start ()
	{
		player = FindObjectOfType<PlaneFly> ();
        TerrainStuff.PlayerIsRespawn += PlayerIsDown;
    }

	public IEnumerator KillPlayerCo()
	{
        Debug.Log ("isplaying coroutine");
        if (StaticVariables.player == false)
        {
            new WaitForSeconds (respawnDelay);
            StaticVariables.player.gameObject.SetActive(true);
        }
			player.GetComponent<Rigidbody>().useGravity = true;
		yield return new WaitForSeconds (delay);
	}
}
