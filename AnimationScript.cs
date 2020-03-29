using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnimationScript : MonoBehaviour
{

	public Animator transitionAnim;
	public string sceneName;


    
    public void ChangeSceneAnim(){
       		StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
    	transitionAnim.SetTrigger("end");
    	yield return new WaitForSeconds(1.5f);
    	SceneManager.LoadScene(sceneName);
    }
}
