using UnityEngine;
using System.Collections;

public class PlaneFly : MonoBehaviour {
	

    public float speed = 100.0f;
	public float altitudeDecline = 50.0f;
	public float altitudeMax = 35.0f;
	public float maxDive = 125.0f;

    void Start ()
    {

    }
	
	void Update ()
	{
		if (StaticVariables.playerHealth < 0) {
			StaticVariables.playerHealth = 0;


		}
	}

	void FixedUpdate ()
	{
		speed -= transform.forward.y * Time.deltaTime * altitudeDecline;

		if (speed < altitudeMax) 
		{
			speed = altitudeMax;
		}
		if (speed > maxDive)
		{
			speed = maxDive;
		}

		transform.Rotate(-Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
