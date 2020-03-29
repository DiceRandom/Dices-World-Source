using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitESC : MonoBehaviour
{
   
    void Update(){
       if(Input.GetButton("Cancel")){
       		 SceneManager.LoadScene("MainMenu");
       } 
    }
}
