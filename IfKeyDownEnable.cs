using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfKeyDownEnable : MonoBehaviour {

	public GameObject oRject;
	public GameObject oRject2;

	void Start(){
		Time.timeScale = 1;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		
	}

	void Update () {
		if(Time.timeScale != 0){
			if(Input.GetButtonDown("Cancel")){
				oRject.SetActive(true);
				Time.timeScale = 0;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
		}else{
			if(Input.GetButtonDown("Cancel")){
				Time.timeScale = 1;
				oRject.SetActive(false);
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}	
		}	
		if(Time.timeScale == 1){
			oRject.SetActive(false);
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

}
