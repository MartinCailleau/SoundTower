using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger1 : MonoBehaviour {

	public AudioClip[] notes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("collision");
		if (other.gameObject.CompareTag ("Sphere")) {
			StartCoroutine (playSound());
		}
	}

	IEnumerator playSound(){
		Random.InitState ((int)Time.time);
		GetComponent<AudioSource> ().clip = notes [Random.Range (0, notes.Length)];
		GetComponent<AudioSource> ().Play ();
		GetComponent<MeshRenderer> ().material.SetColor ("_Color",Color.red);
		yield return new WaitForSeconds (Random.Range(0.2f,2f));
		GetComponent<AudioSource> ().Stop ();
		GetComponent<MeshRenderer> ().material.SetColor ("_Color",Color.white);
	}
}
