using UnityEngine;
using System.Collections;

public class BankFollow : MonoBehaviour {

    public static float speed = 0f;
    public static float distance = 0f;
    public static Vector3 mousePosition;
    public float roationSpeed = 100f;

    public GameObject bankFollowPoint;
    public Transform bankpoint;

    public PlayerCont playerCont;

    // Use this for initialization
    void Start ()
    {
        playerCont = FindObjectOfType<PlayerCont>();
        
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        
               //transform.rotation = Quaternion.Slerp(transform.rotation, bankFollowPoint.transform.rotation, 0.2f);
               transform.rotation = bankpoint.rotation;
               transform.position = Vector3.MoveTowards(transform.position, bankFollowPoint.transform.position, PlayerCont.speed + PlayerCont.distance);

    }
}
