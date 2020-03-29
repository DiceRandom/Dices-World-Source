using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInv : MonoBehaviour {

	public GameObject InvObject;


	void Update () {





		if(Time.timeScale == 1){
			if(Input.GetButton("E")){
				InvObject.SetActive(true);
				Time.timeScale = 0;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}

		}

			if(InvObject.activeSelf){
				if(Input.GetKeyDown(KeyCode.Escape)){
					InvObject.SetActive(false);
					Time.timeScale = 1;
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
			}
		
	}


  public void timeScale1(){
    Time.timeScale = 1;
    InvObject.SetActive(false);
	Cursor.visible = false;
	Cursor.lockState = CursorLockMode.Locked;
  }

}
