using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHUD : MonoBehaviour
{
    public GameObject oRject;
	public bool clack;

	

	void Update () {
		if(Input.GetKeyDown(KeyCode.F1)){
			clack = !clack;
		}

		if(clack == true){
				oRject.SetActive(false);		
			}
			if(clack == false){
				oRject.SetActive(true);
		}
	}

	
}
