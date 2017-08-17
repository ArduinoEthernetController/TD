using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;
    public void Seek(Transform _target)
    {
        target = _target;
    }
	
	// Update is called once per frame
	void Update () {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrane = speed * Time.deltaTime;
        
        if(dir.magnitude <= distanceThisFrane)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrane, Space.World);
	}
    public void HitTarget()
    {
        GameObject effectins = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectins, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
