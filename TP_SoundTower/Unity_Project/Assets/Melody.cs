using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melody : MonoBehaviour
{
    public AudioClip[] notes;
    public float frequence;
    private AudioSource audioSource;
    private int i = 0;

    void Start()
    {
        // L'objectif de ce script est 
        // de jouer les notes du tableau les une après les autres. En boucle.
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("changeNote", 0, frequence);
    }

    void changeNote()
    {
        // On arrête la lecture de la note actuellement joué.
        audioSource.Stop();
        // On donne à l'audioSource la note suivante.
        audioSource.clip = notes[i];
        // Cette partie permet de selectionner en boucle les sons.
        // Si on est au bout du tablea
        if (i + 1 >= notes.Length)
        {
            // Alors on revient au début.
            i = 0;
        }
        else
        {
            // Sinon on passe à la case suivante.
            ++i;
        }
        audioSource.Play();
    }
}
