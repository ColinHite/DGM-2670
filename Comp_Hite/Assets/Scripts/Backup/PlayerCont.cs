using UnityEngine;
using System.Collections;

public class PlayerCont : MonoBehaviour {

	public static float speed = 1;
    public static float distance = 1.0f;
    public static Vector3 mousePosition;
    public int roationSpeed = 100;

    void Start()
    {


    }

    void FixedUpdate()

    {

        //Makes the plane go left and right when the mouse is left or right

        if (Input.mousePosition.x < (Screen.width / 2d))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * roationSpeed);
        }
        else
        {
            transform.Rotate(Vector3.up * Time.deltaTime * roationSpeed);
            //Debug.Log("is doing something");
        }

        //isolates the movement to the mathematical position of the plane
        float distance = (transform.position - GetComponentInChildren<Camera>().transform.position).magnitude;
        //passes Vector3 data from the mouse's position
        mousePosition = Input.mousePosition;
        //Sets the z distance to a point in front of the camera and its speed
        mousePosition.z = distance + speed;
        //Calculates the mouse to the object relativly.
        transform.position = GetComponentInChildren<Camera>().ScreenToWorldPoint(mousePosition);
    }

}
