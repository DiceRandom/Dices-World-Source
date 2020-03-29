using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeButtonLoad : MonoBehaviour
{
    
    public string LevelName;

    public void LoadLevel(){
    	SceneManager.LoadScene(LevelName);
    }

    public void ChangeToGrass(){
    	LevelName = "GrassLevel";
    }

    public void ChangeToCarpet(){
    	LevelName = "CarpetLevel";
    }

    public void ChangeToCity(){
    	LevelName = "City";
    }

}
