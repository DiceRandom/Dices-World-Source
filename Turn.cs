using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
	public float turnSpeed;
	public Transform objectTu;
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}



    void Update(){

    	float DAxis = Input.GetAxis("Vertical") * turnSpeed * Time.deltaTime;


        rb.AddTorque(0, DAxis, 0);
        
    }
}
