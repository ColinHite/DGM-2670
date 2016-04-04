using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public static Quaternion targetRot;
    public static float RotX;
    public static float RotY;
    public static float RotZ;

    public static Vector3 targetPos;
	public static float ViewX;
    public static float ViewY;
    public static float ViewZ;
	public GameObject player;
    public Transform playerView;
	
	
	// Finds object to follow

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Allows for the movment of the camera

	void FixedUpdate () 
	{
        transform.LookAt(playerView);

        ViewX = gameObject.transform.position.x;
        ViewY = gameObject.transform.position.y;
        ViewZ = gameObject.transform.position.z;

		targetPos = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);

		ViewX -= (ViewX - targetPos.x) * 0.1f;
        ViewY -= (ViewY - targetPos.y) * 0.1f;
        ViewZ -= (ViewZ - targetPos.z) * 0.1f;

		gameObject.transform.position = new Vector3(ViewX, ViewY, ViewZ);

        ///////////////////////////////////////////////////
        /*
        RotX = gameObject.transform.rotation.x;
        RotY = gameObject.transform.rotation.y;
        RotZ = gameObject.transform.rotation.z;

        targetRot = new Quaternion(player.transform.rotation.x, player.transform.rotation.y, player.transform.rotation.z, 10);

        RotX += (RotX + targetRot.x) * 1f;
        RotY += (RotY + targetRot.y) * 1f;
        RotZ += (RotZ + targetRot.z) * 1f;

        gameObject.transform.rotation = new Quaternion(RotX, RotY, RotZ, 10);*/
    }
}
