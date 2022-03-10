using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyController : MonoBehaviour
{
  
    public bool isPicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }   
    public void Pickup()
    {
        if (!isPicked)
        {
            isPicked = true;
            Debug.Log("Picked up");
        }
    }

}
