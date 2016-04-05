using UnityEngine;
using System.Collections;

public class PlaneFly : MonoBehaviour {

    public float speed = 5.0f;


    void Start ()
    {

    }
	

	void Update ()
    {
        transform.Rotate(-Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
