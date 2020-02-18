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
        clip = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clip.Play();
        }
    }
}
