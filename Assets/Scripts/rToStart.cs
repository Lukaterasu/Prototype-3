using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rToStart : MonoBehaviour
{
    public GameObject screen0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            screen0.SetActive(true);
            gameObject.SetActive(false);
        }
            
            
    }
}
