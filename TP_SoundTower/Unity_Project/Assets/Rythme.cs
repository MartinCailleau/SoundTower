
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rythme : MonoBehaviour {

    public AudioClip[] drums;
    public float frequence;
	// Use this for initialization
	void Start () {
        // Ordonne au script d'executer la fonction playDrum dès le début du jeu.
        // Et de recommancer toutes les x secondes.
        // x étant la valeur de la variable frequence.
        InvokeRepeating("playDrum", 0, frequence);
    }

    void playDrum()
    {
        // On pioche aleatoirement un son dans le tableau. 
        // Et on le donne à l'audioSource présente sur l'objet Rythmic.
        GetComponent<AudioSource>().clip = drums[Random.Range(0, drums.Length)];
        GetComponent<AudioSource>().Play();
    }
}
