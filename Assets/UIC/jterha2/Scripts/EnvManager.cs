using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnvManager : MonoBehaviour
{
    //each contains a list of delagates to run
    //this allows actions to be described in the editor w/o code
    public UnityEvent onDaytime;
    public UnityEvent onNighttime;
    
    // Start is called before the first frame update
    void Start()
    {
        onDaytime.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsDayChecked(bool check)
    {
        //Day is the default and when deselected, night is the 
        //only other option. Thus day will be false when night
        //is selected.
        Console.WriteLine($"Value: {check}");
        if (check)
        {
            onDaytime.Invoke();
        }
        else
        {
            onNighttime.Invoke();
        }
    }
}
