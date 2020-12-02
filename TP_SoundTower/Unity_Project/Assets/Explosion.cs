using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Explosion : MonoBehaviour {

    public float force = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, 5f);
        }
        
	}

}
