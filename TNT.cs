using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{

	public float range;
    public float tntTime;
	public Material White;
    private Rigidbody rb;
    public float minExplosionRadius = 4f;
    public float maxExplosionRadius = 5f;
    private Vector3 explosionPosition;
    private Collider[] colliders;
    private Collider[] collidersForTNT;


    void Start(){
        rb = GetComponent<Rigidbody>();
        explosionPosition = transform.position;

        colliders = Physics.OverlapSphere(explosionPosition, Random.Range(minExplosionRadius, maxExplosionRadius));
        collidersForTNT = Physics.OverlapSphere(explosionPosition, maxExplosionRadius + 2f);
    }

    public void OnDestroy(){
        StartCoroutine(Explode(tntTime));
    }


    public IEnumerator Explode(float eTime){
        rb.isKinematic = false; //Physics
    	yield return new WaitForSeconds(eTime); //Wait
        foreach (var col in colliders)
        {
          if (col.GetComponent<Collider>().tag == "object")
          {
            if(!col.GetComponent<TNT>()){
                Destroy(col.gameObject);
            }
          }
        }

    
        Destroy(this);
    }



}
