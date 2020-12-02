using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundNote : MonoBehaviour {


    public AudioClip[] notes;
	private AudioSource audioSource;
	private int i = 0;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource> ();
        InvokeRepeating("changeNote",0,2);
    }
	
    void changeNote()
    {
        audioSource.Stop();
        audioSource.clip = notes[i];
		if (i+1 >= notes.Length) {
			i = 0;
		}else{
			++i;	
		}

        audioSource.Play();
    }

	// Update is called once per frame
	void Update () {
        
    }
}
