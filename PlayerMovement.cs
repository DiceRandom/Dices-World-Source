using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float mouseSpeed;
	public float DPadSpeed;
	public int lookStop;
	public Rigidbody rb;
	public Transform Cam;
	public Transform pivot;
	public Vector2 moveDir;
	private bool isMovingForward;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		 Vector3 CamF = Cam.forward;
		 Vector3 CamR = Cam.right;
		 	CamF.y = 0;
			CamR.y = 0;
			CamF = CamF.normalized;
			CamR = CamR.normalized;
		 //KEYBOARD INPUT
		 float xAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		 float yAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime ;
		 Vector2 input = new Vector2(xAxis, yAxis);
		 //MouseInput

		 float MouseYAxis = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime ;
		 float MouseXAxis = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime ;

		 //float dpadXAxis = Input.GetAxis("DPad X") * DPadSpeed * Time.deltaTime ;
		 //float dpadYAxis = Input.GetAxis("DPad Y") * DPadSpeed * Time.deltaTime ;

		 //STOP CAM GOING TOO FAR UP
		 MouseYAxis = Mathf.Clamp(MouseYAxis, -lookStop, lookStop);

		rb.position += (CamF*input.y + CamR*input.x);

		//pivot.Rotate(MouseYAxis,MouseXAxis,0);
		//pivot.Rotate(dpadYAxis,dpadXAxis,0);
		//Cam.rotation = Quaternion.Euler(MouseYAxis, 0, 0);

		


	}



	 void OnTriggerEnter(Collider other)
 	{
    if(other.gameObject.tag=="slab")
     Destroy(gameObject);    
 	}



}
