using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressto : MonoBehaviour
{
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F11)){
        	 Screen.fullScreen = !Screen.fullScreen;
        }

 

         if(Input.GetKeyDown(KeyCode.Keypad7)){
        	 Screen.SetResolution(1280, 720, true);
        }

        if(Input.GetKeyDown(KeyCode.Keypad8)){
        	 Screen.SetResolution(1920, 1080, true);
        }

        if(Input.GetKeyDown(KeyCode.Keypad4)){
        	 Screen.SetResolution(1024, 768, true);
        }
    }
}
