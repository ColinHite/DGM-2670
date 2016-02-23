using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnControl : MonoBehaviour {
	
	public MeshRenderer meshRenderer;
	public List<Transform> spawnPoints;

	void AddToSpawnPointsList (Transform _spawnPoint)
	{

		spawnPoints.Add (_spawnPoint);

	}

	void Start ()
	{
		spawnPoints = new List<Transform> ();
		SetThisAsSpawnPoint.PassTransformAsSpawnPoint += AddToSpawnPointsList;

	}

	IEnumerator Spawn ()
	{
		yield return new WaitForSeconds (2);
		meshRenderer.enabled = true;

		int randomSpawnPointNum = Random.Range (0, spawnPoints.Count - 1);

		transform.position = spawnPoints[randomSpawnPointNum].position;

	}

	void OnMouseDown ()
	{
		meshRenderer.enabled = false;
		StartCoroutine (Spawn ());
	}

}
