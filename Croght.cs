using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croght : MonoBehaviour
{
    public Animator ani;



    // Update is called once per frame
    void Update()
    {
    	if(Input.GetButton("Crouch")){
    		ani.SetBool("crouched", true);
    	}else{
    		ani.SetBool("crouched", false);
    	}
}
}