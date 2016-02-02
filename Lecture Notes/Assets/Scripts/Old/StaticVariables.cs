using UnityEngine;
using System.Collections;

public class StaticVariables : MonoBehaviour {

	public enum myAvalibleWeapons
	{

		Knife,
		Gun,
		Spoon

	}
	
	public static int playerAmmo = 10;
	public static float playerHealth = 1.0f;

	//public static myAvalibleWeapons CurrentWeapon = myAvalibleWeapons.Knife;

}
