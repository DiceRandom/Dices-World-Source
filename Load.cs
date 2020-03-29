using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Load : MonoBehaviour
{
    
	
	public GameObject SaveHandler;
	public GameObject Pivot;
	public GameObject audioGO;
	private AudioSource audioListener;
	public bool changeMouse = true;



	public float mouseSensitivityValue;
	public float musicVolumeValue;



    void Start(){
    	audioListener = audioGO.GetComponent<AudioSource>();

	     mouseSensitivityValue = SaveHandler.GetComponent<MusicSave>().mouseSensitivityValue;
	     musicVolumeValue = SaveHandler.GetComponent<MusicSave>().musicVolumeValue;
	    if(changeMouse){
	    	Pivot.GetComponent<MouseLook>().sensitivityY = mouseSensitivityValue;
	    	Pivot.GetComponent<MouseLook>().sensitivityX = mouseSensitivityValue;
	 	}
	     audioListener.volume = musicVolumeValue;
    }

    public void LoadInfo(){
    	mouseSensitivityValue = SaveHandler.GetComponent<MusicSave>().mouseSensitivityValue;
	    musicVolumeValue = SaveHandler.GetComponent<MusicSave>().musicVolumeValue;

	    if(changeMouse){
	    	Pivot.GetComponent<MouseLook>().sensitivityY = mouseSensitivityValue;
	    	Pivot.GetComponent<MouseLook>().sensitivityX = mouseSensitivityValue;
	 	}
	    audioListener.volume = musicVolumeValue;
    }

}
