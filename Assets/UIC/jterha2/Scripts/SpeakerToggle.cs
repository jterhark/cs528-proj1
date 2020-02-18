using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerToggle : MonoBehaviour
{

    private AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        //get the audio attached to the game object this
        //script is attached to.
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //each controller has a box collider, so only play the audio
        //if a controller enters the collider attached to
        //this object
        if (!other.CompareTag("Controller")) return;
        
        if (audio.isPlaying)
        {
            audio.Stop();
        }
        else
        {
            audio.Play();
        }
    }
}
