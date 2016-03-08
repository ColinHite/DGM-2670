using UnityEngine;
using System.Collections;

public class SimpleCC : MonoBehaviour {

    private CharacterController character;
    
    private Vector3 moveDistance;
    public float moveSpeed = 5;
    public float rotateSpeed = 2;
    public float gravity = -9.81f;
    
	// Use this for initialization
	void Start () 
    {
	character = GetComponent<CharacterController> ();
	}
    
    void Rotate (float _myInput)
    {
        
        transform.Rotate(0, _myInput *rotateSpeed, 0);
        
    }
    
    void Move (float _myInput)
    {
        
     moveDistance.x = _myInput;
     moveDistance = transform.TransformDirection(moveDistance * moveSpeed *Time.deltaTime);
         character.Move (moveDistance);
        
    }
	
	// Update is called once per frame
	void Update () 
    {
	   moveDistance.y = gravity*Time.deltaTime;
        Move(Input.GetAxis ("Vertical"));
        Rotate (Input.GetAxis ("Horizontal"));
	}
}
