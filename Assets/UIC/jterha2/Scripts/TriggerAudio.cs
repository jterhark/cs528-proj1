using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{

    private AudioSource clip;
    
    // Start is called before the first frame update
    void Start()
    {
        //get the audio attached to the game object this
        //script is attached to.
        clip = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the player enters the area, play some sound.
        if (other.CompareTag("Player"))
        {
            clip.Play();
        }
    }
}
