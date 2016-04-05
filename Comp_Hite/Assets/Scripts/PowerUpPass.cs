using UnityEngine;
using System.Collections;

public class PowerUpPass : MonoBehaviour {

	public void PowerUp(float health)
	{
		StaticVariables.playerHealth += health;
	}
}
