using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
 
    public GameObject objectToSpawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Breadcrumb!");
            Instantiate(objectToSpawn, transform.position + (transform.forward * 2), transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Restart!");
            SceneManager.LoadScene("SampleScene");
        }

    }
    

}
