using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
			Debug.Log (Input.mousePosition);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction*10,Color.red,1f);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.tag == "SoundTrigger")
                {
                    Vector3 v = hit.transform.position;
                    v.y += 10;
                    Instantiate(prefab, v, Quaternion.identity);
                }
            }

        }
	}
}
