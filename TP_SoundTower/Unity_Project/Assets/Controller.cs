using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public float speed = 10;
    public float rotationSpeed = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,0, -Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(Vector3.forward, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed);
	}
}
