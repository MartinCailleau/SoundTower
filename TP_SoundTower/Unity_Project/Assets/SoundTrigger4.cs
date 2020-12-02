using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator playSound(){
		// Prepare le tirage aléatoire
		Random.InitState ((int)Time.time);
		// pioche au hazard un audioClip dans le tableau.
		// Assigne l'audioClip pioché à la variable clip du component AudioSource du GameObject
		//GetComponent<AudioSource> ().clip = notes [Random.Range (0, notes.Length)];
		// Appel de la fonction Play du component AudioSource => Play l'audioClip. 
		GetComponent<AudioSource> ().Play ();
		// Change la couleur de material
		//GetComponent<MeshRenderer> ().material.SetColor ("_Color",Color.red);
		yield return new WaitForSeconds (Random.Range(0.2f,2f));
		//GetComponent<AudioSource> ().Stop ();
		//GetComponent<MeshRenderer> ().material.SetColor ("_Color",Color.white);
	}
}
