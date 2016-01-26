using UnityEngine;
using System.Collections;

public class StaticPumpkins : MonoBehaviour {

	//This Changes the state (abilities and attributes) of the pumpkins.
	public enum AvalibleStates {
		
		Standard,
		Ice,
		Fire,
		Nuke
		
	}
	
	public static AvalibleStates currentState = AvalibleStates.Standard;

}
