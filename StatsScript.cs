using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsScript : MonoBehaviour
{

	public GameObject StatsMenu;
	public bool isMenuActive;

	public TextMeshProUGUI timesOpenedMenuText;
	public int timesOpenedMenu = 4;

	public TextMeshProUGUI numOfJumpsText;
	public int numOfJumps;

	public TextMeshProUGUI timeSpentPlaying;
	public float timez;

	public TextMeshProUGUI numOfBlocksDestroyedText;
	public float numOfBlocksDestroyed;


	public TextMeshProUGUI objectsPlacedText;
	public float objectsPlacedV;



    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI  timesOpenedMenuText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("StatsMenu")){
        	if(!StatsMenu.activeSelf){
        		timesOpenedMenu++;
       		}
        	timesOpenedMenuText.SetText(timesOpenedMenu.ToString());
        	timeSpentPlaying.SetText(Mathf.RoundToInt(timez / 60).ToString() + "m");
        	isMenuActive = !isMenuActive;
        
        }
        numOfBlocksDestroyedText.SetText(numOfBlocksDestroyed.ToString());
        objectsPlacedText.SetText(objectsPlacedV.ToString());
        numOfJumpsText.SetText(numOfJumps.ToString());


        StatsMenu.SetActive(isMenuActive);
        timez += Time.deltaTime;

    }

}




	