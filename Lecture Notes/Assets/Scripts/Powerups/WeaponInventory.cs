using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponInventory : MonoBehaviour {

	public List<WeaponClass> weapons;
	public Transform weaponHolder;

	int i = 0;

	void AddToInventory (WeaponClass _weapon) 
	{
//		print (_weapon.name);

		weapons.Add (_weapon);
		_weapon.transform.parent = weaponHolder;
		_weapon.transform.localPosition = Vector3.zero;
	}

	void WeaponSwitch ()
	{

		if (weapons.Count > 0) 
		{
			weapons [i].gameObject.SetActive (false);
			if (i < weapons.Count-1)
			{		
				i++;
			}
			else {
				i = 0;
			}
			weapons [i].gameObject.SetActive (true);
		}

	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.S)) {
			WeaponSwitch();
		}
	}

	void Start () {
		weapons = new List<WeaponClass> ();
		WeaponClass.PassWeapon += AddToInventory;
	}

}
