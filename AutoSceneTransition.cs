using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneTransition : MonoBehaviour
{

	public Animator transitionAnim;
	public string sceneName;
	public float secondsToWaitStart;
    
    void Update(){
       		StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
    	yield return new WaitForSeconds(secondsToWaitStart);
    	transitionAnim.SetTrigger("end");
    	yield return new WaitForSeconds(1.5f);
    	SceneManager.LoadScene(sceneName);
    }
}
