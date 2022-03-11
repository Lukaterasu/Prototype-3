using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flashing_Label;
    public GameObject white_screen;
    public GameObject screen0;
    public GameObject thisText;
    public float interval;

    void Start()
    {
        InvokeRepeating("FlashLabel", 0, interval);

       

    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
            {
            print("pressed");
            screen0.SetActive(true);
            white_screen.SetActive(false);
            Destroy(thisText);
            
        }
    }

    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
        {
            flashing_Label.SetActive(false);
        }
        else
        {
            flashing_Label.SetActive(true);
        }
            
    }

}
