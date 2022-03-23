using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour {

    public AudioClip[] notes;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(blink());
    }

    IEnumerator blink()
    {
        // Le marche devient rouge
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);

      //  GetComponent<Animator>().SetBool("colorChange", true);

        // On change la seed de l'algoritme random, pour avoir un tirage plus aléatoire.
        Random.InitState((int)Time.time);
        // On pioche au aléatoirement un son (audioClip) dans le tableau d'audioClip.
        // Et on donne cet audioClip au component AudioSource de la marche.
        GetComponent<AudioSource>().clip = notes[Random.Range(0,notes.Length)];
        // L'audioSource est un lecteur de fichiers son (audioClip). 
        // On lui demande alors de jouer le son qu'il lui a été donné plus haut.
        GetComponent<AudioSource>().Play();
        // On attend entre 0.5 et 2 secondes (vous pouvez changer ces valeurs comme vous voulez.)
        // Cette attente correspond au temps d'emission du son déclenché.
        yield return new WaitForSeconds(Random.Range(0.5f,2f));
        // Une fois l'attente terminé. On arrête la lecture du son.
        GetComponent<AudioSource>().Stop();
       // GetComponent<Animator>().SetBool("colorChange", false);
        // On marche redevient blanche.
        GetComponent<Renderer>().material.SetColor("_Color", Color.white);
    }
}
