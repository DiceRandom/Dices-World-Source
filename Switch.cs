using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandTerminal;

public class Switch : MonoBehaviour {

	public GameObject[] Hud;
	public GameObject[] Placer;

	public float currentLine;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//											-1-
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			Select(1, false);
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)){
			Select(2, false);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			Select(3, false);
		}
		if(Input.GetKeyDown(KeyCode.Alpha4)){
			Select(4, false);
		}
		if(Input.GetKeyDown(KeyCode.Alpha5)){
			Select(5, false);
		}


		if(Input.GetKeyDown(KeyCode.Q)){
			Select(6, true);		
		}






		if(Input.GetKeyDown(KeyCode.Z)){

		}
	}

	public void SetLineTo1(){
		currentLine = 1;
	}

	public void SetLineTo2(){
		currentLine = 2;
	}


	public void Select(int itemNum, bool ignoreCL){
		for(int i = 0; i < Hud.Length; i++){
	       Hud[i].SetActive(false);
	       Placer[i].SetActive(false);
	    }

	    if(ignoreCL == true){
	    	Hud[itemNum - 1].SetActive(true);
	    	Placer[ itemNum - 1].SetActive(true);
	    }else{
	    	if(currentLine == 1){
	    	Hud[itemNum - 1].SetActive(true);
	    	Placer[ itemNum - 1].SetActive(true);
		    }else{
			    if(currentLine == 2){
			    	Hud[itemNum - 1 + 6].SetActive(true);
			    	Placer[itemNum - 1 + 6].SetActive(true);
			    }
			}
	    }
	    
	}
}
