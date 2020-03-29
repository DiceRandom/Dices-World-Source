using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartString : MonoBehaviour
{

	public TextMeshProUGUI  startString;

    void Start()
    {
    	TextMeshProUGUI  startString = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
         string day = System.DateTime.Now.ToString("MM/dd");

         //Debug.Log(day);

         //halloween
         if(day  == "10/31")
         {
            startString.SetText("Happy Halloween");
         }else{

         	if(day  == "12/31" || day  == "1/1"){
           	 startString.SetText("Happy New Year");
         	}else{
         		 if(day  == "12/25"){
            		startString.SetText("Merry Christmas");
        		}else{
        			if(day  == "01/09"){
            		startString.SetText("Happy Birthday, Dice");
         			}else{
         				if(day  == "04/01"){
            				startString.SetText("APRIL FOOLS!");
           					 startString.faceColor = new Color32(255, 0, 220, 255);
            				startString.fontSize = 50.5f;
         				}else{
         					if(day == "03/02"){
         					startString.SetText("§1C§2o§3l§4o§5r§6m§7a§8t§9i§ac");
         					}else{
         						if(day == "02/14" || day == "6/12"){
         					startString.SetText("sqrt(-1) love you ashleigh <3 Ɛ> ♥");
         					}else{
                                if(day == "04/29"){
                                   startString.SetText("throw yourself at the ground and miss"); 
                                }else{
         						startString.SetText("May Contain Milk.");
         					}
                        }

         				}
         				}
         			}
        		}
         	}
         }

    }
}
