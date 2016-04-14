using UnityEngine;
using System.Collections;

public class TerrainStuff : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        col.gameObject.SetActive(false);
        Debug.Log("is hitting ground");
    }
}
