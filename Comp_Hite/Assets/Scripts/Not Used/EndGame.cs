using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public float health = 1f;
	public Transform healthBar;

	private Vector3 healthScale;


	void Start ()
	{

		healthScale.y = 1;
		healthScale.z = 1;

	}



	IEnumerator EndThisGame ()
	{
		yield return new WaitForSeconds (1);
		Application.LoadLevel("EndGame");
	}

	// Use this for initialization
	void OnMouseDown () {
		health -= 0.1f;
		healthScale.x = health;
		healthBar.localScale = healthScale;

		if (health > 0)
			return;

		StartCoroutine (EndThisGame ());
	}

}
