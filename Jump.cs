using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {




	bool isgrounded = true;
	public float JumpForce;
    public Rigidbody rb;
    public int numberOfJumps = 0;
    public GameObject statsObject;

    void Start (){
        rb = GetComponent<Rigidbody>();
        numberOfJumps = statsObject.GetComponent<StatsScript>().numOfJumps;
    }



 void Update(){
     if (isgrounded == true){
     	if(Input.GetButtonDown("Jump")){
         rb.AddForce(0, JumpForce, 0);
         numberOfJumps++;
         statsObject.GetComponent<StatsScript>().numOfJumps = numberOfJumps;
          //Debug.Log("shouldve jumped");
     	}
     }
 }

 		//make sure u replace "floor" with your gameobject name.on which player is standing
 	void OnCollisionEnter(Collision theCollision){
 		//Debug.Log("ENTER");

     	if (theCollision.gameObject.tag == "object" && theCollision.gameObject.tag == "Not Breakable"){
         isgrounded = true;
          //Debug.Log("grounded true");
     	}
 	}

 		//consider when character is jumping .. it will exit collision.
 	void OnCollisionExit(Collision theCollision){
 		//Debug.Log("EXIT");
     	if (theCollision.gameObject.tag == "object" && theCollision.gameObject.tag == "Not Breakable"){
         isgrounded = false;
        // Debug.Log("grounded false");
     }
 	}


}
