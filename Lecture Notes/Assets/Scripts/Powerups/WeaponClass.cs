using UnityEngine;
using System.Collections;
using System;

public class WeaponClass : MonoBehaviour {

	public static Action<WeaponClass> PassWeapon;

	void OnTriggerEnter()
	{
		print (this);
		if (PassWeapon != null)
			PassWeapon (this);

		gameObject.SetActive (false);
	}
}
