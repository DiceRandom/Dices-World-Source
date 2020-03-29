using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CommandTerminal;

public class MusicSave : MonoBehaviour
{


    isGravityOn

    gravityDefault


                this.gravity = 0f;

    this.gravityDefault = this.gravity;


	public KeyCode keycode = KeyCode.None;
    public KeyCode loadKey = KeyCode.None;
	public bool switched;
	public bool isOn;
    public bool isMusicOn;
	public GameObject Object1;

    public bool GetMouseInfo;
    public GameObject mouseSensitivityGO;
    public float mouseSensitivityValue;
    public Slider mouseSensSlider;


    public bool GetMusicVolume;
    public GameObject musicVolumeGO;
    public float musicVolumeValue;
    public Slider musicVSlider;




    public GameObject ToggleButton;



    void Start(){
        isMusicOn = !isOn;
        mouseSensitivityValue = JsonUtility.FromJson<SaveObject>(File.ReadAllText(Application.dataPath + "/config/" + "config.txt")).mouseSensitivity;

        ToggleButton.GetComponent<UnityEngine.UI.Toggle>().isOn = isMusicOn;
        if(GetMouseInfo){
            mouseSensSlider.value = mouseSensitivityValue;
            mouseSensitivityGO.GetComponent<MouseSensitivity>().mouseSensitivity = mouseSensitivityValue;
        }

        if(GetMusicVolume){
            musicVSlider.value = musicVolumeValue;
            musicVolumeGO.GetComponent<GetMusicSlider>().musicVolume = musicVolumeValue;
        }
    }


	private void Awake(){

		SaveObject saveObject = new SaveObject{
			isMusicOn = true,
            mouseSensitivity = 10,
            musicVolume = 1,
		};
		string json = JsonUtility.ToJson(saveObject);
		Debug.Log(json);

		SaveObject loadedSaveObject = JsonUtility.FromJson<SaveObject>(json);
		//Debug.Log(loadedSaveObject.isMusicOn);

		Load();

	}



    void Update(){

        if(GetMouseInfo){
            mouseSensitivityValue = mouseSensitivityGO.GetComponent<MouseSensitivity>().mouseSensitivity;
        }

        if(GetMusicVolume){
            musicVolumeValue = musicVolumeGO.GetComponent<GetMusicSlider>().musicVolume;
        }

        if(isMusicOn){
            isOn = !isMusicOn;
        }

        if(!isMusicOn){
            isOn = !isMusicOn;
        }   



        if(Input.GetKeyDown(keycode)){
        	isOn = !isOn;

            isMusicOn = !isOn;

        	Save();
        }

        if(!switched){
        	Object1.SetActive(!isOn);
       	}else{
        	Object1.SetActive(isOn);
       	}

        if(Input.GetKeyDown(loadKey)){
            Load();
        }

    }

   

    private void Load(){
    	if(File.Exists(Application.dataPath + "/config/" + "config.txt") ){
            string saveString = File.ReadAllText(Application.dataPath + "/config/config.txt");
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            isOn = !saveObject.isMusicOn;
            mouseSensitivityValue = saveObject.mouseSensitivity;
            musicVolumeValue = saveObject.musicVolume;
        }else{
            Terminal.Log("FILE NOT FOUND 1 ");
        }

        if(File.Exists(Application.dataPath + "/config/config.txt") ){
            string saveString = File.ReadAllText(Application.dataPath + "/config/config.txt");
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            isOn = !saveObject.isMusicOn;
            mouseSensitivityValue = saveObject.mouseSensitivity;
            musicVolumeValue = saveObject.musicVolume;
        }else{
            Terminal.Log("FILE NOT FOUND 2 ");
        }

         if(File.Exists(Application.dataPath + "/config" + "config.txt") ){
            string saveString = File.ReadAllText(Application.dataPath + "/config/config.txt");
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            isOn = !saveObject.isMusicOn;
            mouseSensitivityValue = saveObject.mouseSensitivity;
            musicVolumeValue = saveObject.musicVolume;
        }else{
            Terminal.Log("FILE NOT FOUND 3 ");
        }
    }




    public void Save(){
    	bool failed = false;

    	SaveObject saveObject = new SaveObject{
			isMusicOn = !isOn,
            mouseSensitivity = mouseSensitivityValue,
            musicVolume = musicVolumeValue,
		};


		try{
 			if (!Directory.Exists(Application.dataPath + "/config")){
            	Directory.CreateDirectory(Application.dataPath + "/config");
       		}
		}
		catch{
			failed = true;
		}
    	




		string json = JsonUtility.ToJson(saveObject);

		if(!failed){
			File.WriteAllText(Application.dataPath + "/config/config.txt",json);
		}else{
			if (!Directory.Exists(Application.dataPath + "/config")){
            	Directory.CreateDirectory(Application.dataPath + "/config");
       		}

			File.WriteAllText(Application.dataPath + "/config/config.txt",json);
		}

    }



    public class SaveObject{
    	public bool isMusicOn;
        public float mouseSensitivity;
        public float musicVolume;
    }





    public void ToggleMusic(bool fuckUnity){
        isMusicOn = fuckUnity;
    }

}
