using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponInventory : MonoBehaviour {

	public List<WeaponClass> weapons;

	void AddToInventory (WeaponClass _weapon) 
	{
		print (_weapon.name);
		weapons.Add (_weapon);
	}

	void Start () {
		weapons = new List<WeaponClass> ();
		WeaponClass.PassWeapon += AddToInventory;
	}

}
