using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCone : MonoBehaviour

{ 

    public Material[] material;
    Renderer rend;
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend.sharedMaterial = material[1];
            PlayRandom();
        }
          
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend.sharedMaterial = material[0];
        }

    }

    void PlayRandom()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }

}
