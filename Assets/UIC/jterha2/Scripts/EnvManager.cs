using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnvManager : MonoBehaviour
{
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
