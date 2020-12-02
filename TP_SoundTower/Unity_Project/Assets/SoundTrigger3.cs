using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger3 : MonoBehaviour {
	public AudioClip[] notes;
	private AudioSource audio;
	private MeshRenderer render;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		render = GetComponent<MeshRenderer>();
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
		Random.InitState((int)Time.time);
		audio.clip = notes [Random.Range (0, notes.Length)];
		audio.Play ();
		render.material.SetColor ("_Color",Color.red);
		yield return new WaitForSeconds (Random.Range(0.2f,2f));
		audio.Stop ();
		render.material.SetColor ("_Color",Color.white);
	}
}
