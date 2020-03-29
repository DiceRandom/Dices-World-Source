using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSplash : MonoBehaviour
{
	public Transform rotateObject;
	public int RotateSpeed;
	private int RotateSpeed2;
	public int RotateStop;
	public int currentRotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateObject.localScale += new Vector3(currentRotate, 0, 0);

        currentRotate = 2 * RotateSpeed;

        if(currentRotate == RotateStop){
        	RotateSpeed = -RotateSpeed2;
        }

        if(currentRotate == -RotateStop){
        	RotateSpeed = RotateSpeed2;
        }
    }
}
