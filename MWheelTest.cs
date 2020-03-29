using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MWheelTest : MonoBehaviour
{
	public float MWheelValues;
	public bool mUp;
	public bool mDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MWheelValues = Input.GetAxis("Mouse ScrollWheel");

        if(MWheelValues > 0.01){
        	mUp = true;
        	mDown = false;
        }else{
        	if(MWheelValues < -0.01){
        		mUp = false;
        		mDown = true;
        	}else{
        		mUp = false;
        		mDown = false;
        	}
        }

    }
}
