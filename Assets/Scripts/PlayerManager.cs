using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
 
    
    public float minPos;
    private CharacterController character;
    float timer = 32;
    public GameObject enemyPrefab;
    private bool question = true;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        question = true;
        if (transform.position.y < minPos)
        {
            SoundManager.PlaySound("Falling SFX");
        }
        timer -= Time.deltaTime;
        if (Mathf.RoundToInt(timer) <= 0)
        {
            if (question)
            {
                Instantiate(enemyPrefab, new Vector3(10f, 0.5f, 18f), Quaternion.identity);
                question = false;
                timer = 15.5f;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Restart!");
            SceneManager.LoadScene("SampleScene");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            character.SimpleMove(Vector3.forward * 50);
        }
    }
}
