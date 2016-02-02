using UnityEngine;
using System.Collections;

public class PumpkinStateMachine : MonoBehaviour {

	public PumpkinControler pumpkinController;
	private MeshRenderer thisMaterial;

	public StaticPumpkins.AvalibleStates thisPumpkinsState;

	void ChangeState (int _i)
	{
		thisMaterial = GetComponent<MeshRenderer> ();
		thisMaterial.material = pumpkinController.pumpkinMaterial[_i];

//		print (pumpkinController.pumpkinMaterial [_i]);
//		print (_i)

	}

	void SwitchState ()
	{
		switch (thisPumpkinsState) {
		case StaticPumpkins.AvalibleStates.Standard:
			ChangeState (0);
			break;
		case StaticPumpkins.AvalibleStates.Ice:
			ChangeState (1);
			break;
		case StaticPumpkins.AvalibleStates.Fire:
			ChangeState (2);
			break;
		case StaticPumpkins.AvalibleStates.Nuke:
			ChangeState (3);
			break;
		}
	}


		void Start ()
	{

		SwitchState ();

	}
}
