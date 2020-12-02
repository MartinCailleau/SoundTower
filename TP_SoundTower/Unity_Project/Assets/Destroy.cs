using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
        }
    }

}
