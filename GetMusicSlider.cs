using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetMusicSlider : MonoBehaviour
{
    
    public float musicVolume;
    public GameObject saveVid;
    public Slider musicSlider;

    void Update(){
    	musicVolume = musicSlider.value;
    	saveVid.GetComponent<Load>().LoadInfo();
    }
}
