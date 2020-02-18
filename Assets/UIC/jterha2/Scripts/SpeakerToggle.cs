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
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
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
