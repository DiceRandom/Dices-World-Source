using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockOnSceneLoad : MonoBehaviour
{
    void Start(){
		Time.timeScale = 1;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		
	}
}
