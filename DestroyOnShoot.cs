using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnShoot : MonoBehaviour {

	public int distance;
	public Camera cam;
	public GameObject destoryEffect;
	public GameObject tntDestoryEffect;
	public Vector3 particalRotation;

	public GameObject statsObject;
	public float numberOfBlocksDestored;
	
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			ShootRay();

		}
	}

	void ShootRay(){

	RaycastHit hit;

	if(Time.timeScale == 1.0){
		if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distance)){
			if(hit.transform.tag == "object"){

				if(!hit.transform.gameObject.GetComponent<TNT>()){
					GameObject effectIG = Instantiate(destoryEffect, hit.point, Quaternion.Euler(particalRotation));
					Destroy(effectIG, 2f);
					Destroy(hit.transform.gameObject);
					numberOfBlocksDestored++;
					statsObject.GetComponent<StatsScript>().numOfBlocksDestroyed = numberOfBlocksDestored;
				}else{
					Debug.Log("TNT");
					hit.transform.gameObject.GetComponent<TNT>().OnDestroy();
					numberOfBlocksDestored++;
					statsObject.GetComponent<StatsScript>().numOfBlocksDestroyed = numberOfBlocksDestored;
				}
			}
			
		}
	}
}
}
