using UnityEngine;
using System.Collections;

public class YellowSphere : MonoBehaviour {

    //public float distance = 1.0f;
    public Vector3 mousePosition;

    void Start ()
    {

        
    }

	void Update ()

    {
        //isolates the movement to the mathematical position of the plane
        //float distance = (transform.position - GetComponentInChildren<Camera>().transform.position).magnitude;
        //passes Vector3 data from the mouse's position
        mousePosition = Input.mousePosition;
        //Sets the z distance to a point in front of the camera 
        //mousePosition.z = distance + speed;
        //Calculates the mouse to the object relativly.
        transform.position = GetComponentInChildren<Camera>().ScreenToWorldPoint(mousePosition);
	}
	

}
