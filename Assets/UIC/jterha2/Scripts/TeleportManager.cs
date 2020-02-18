using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject NorthWest, NorthEast, SouthWest, SouthEast;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Since an event is emitted whenever a toggle is selected/deselected
    //each handler needs to check if the value is true.
    public void TeleportNW(bool x)
    {
        if (x)
        {
            player.transform.position = NorthWest.transform.position;
        }
    }

    public void TeleportNE(bool x)
    {
        if (x)
        {
            player.transform.position = NorthEast.transform.position;
        }
    }

    public void TeleportSW(bool x)
    {
        if (x)
        {
            player.transform.position = SouthWest.transform.position;
        }
    }

    public void TeleportSE(bool x)
    {
        if (x)
        {
            player.transform.position = SouthEast.transform.position;
        }
    }
}
