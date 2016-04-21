using UnityEngine;
using System;
using System.Collections;

	public class PlaneDown : MonoBehaviour {

	//private PlaneFly player;

	public GameObject player;

	private float delay = 20.0f;
    public float respawnDelay = 10.0f;

	public static bool isDead = false;

    public void PlayerIsDown(TerrainStuff _isDead)
    {
        StartCoroutine("KillPlayerCo");
    }


    void Start ()
	{
		//player = FindObjectOfType<PlaneFly> ();
        TerrainStuff.PlayerIsRespawn += PlayerIsDown;
    }

	public IEnumerator KillPlayerCo()
	{
        Debug.Log ("isplaying coroutine");
        if (isDead == true)
        {
			StartCoroutine("Reviving");
        }

		if (StaticVariables.playerHealth == 0.0f) 
		{
			player.GetComponent<Rigidbody> ().useGravity = true;
		}
		yield return new WaitForSeconds (delay);

	}
	public IEnumerator Reviving()
	{
		yield return new WaitForSeconds (respawnDelay);
		
		player.transform.position = new Vector3 (0, 3, 0);
		player.transform.rotation = new Quaternion (0,0,0,0);
		player.gameObject.SetActive(true);
		isDead = false;
	}
}
