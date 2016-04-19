using UnityEngine;
using System;
using System.Collections;

public class TerrainStuff : MonoBehaviour
{
    public static Action <TerrainStuff> PlayerIsRespawn;

    
    void OnCollisionEnter(Collision col)
    {
        col.gameObject.SetActive(false);
        //StaticVariables.playerHealth = 0;
        Debug.Log("is hitting ground");

        if (col.gameObject == false)
        {
            Debug.Log("Is Respawning");
        }

        if (PlayerIsRespawn != null)
            PlayerIsRespawn(this);
    }
}
