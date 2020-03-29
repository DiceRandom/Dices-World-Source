using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
	public GameObject[] wantToSaveObjects;

	public Vector3[] ObjectsPos;


    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        wantToSaveObjects = GameObject.FindGameObjectsWithTag("object");

        if(Input.GetKeyDown(KeyCode.P)){
        	SaveData();
        }



       


    }

    public void SaveData(){

 		for(int i = 0;i < wantToSaveObjects.Length; i++)
   		{
       		 Debug.Log(wantToSaveObjects[i].transform.position);

       		 //ObjectsPos[i] =
    	}

    	
    	var data = JsonUtility.ToJson(wantToSaveObjects);
    	PlayerPrefs.SetString("GameData", data);

    	string path = "C:/.dicesworld/world.txt";

    	if(!File.Exists(path)){
    		File.WriteAllText(path, "World Data \n\n");
    	}

    	string[] finalObjPos;

    	for(int e = 0;e < ObjectsPos.Length; e++)
   		{
       	//	finalObjPos = ObjectsPos[e].Split(',');
    	}

    	


    	//File.AppendAllText(path, finalObjPos);
    }
}
