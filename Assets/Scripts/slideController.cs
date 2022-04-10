using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class slideController : MonoBehaviour
{
    public bool tileReset = false;
    public bool isQuestion = false;
    public bool displaced = false;
    public int correctTile;
    public float timer = 15;
    public float minPos = -2f;
    public GameObject thisSlide;
    public GameObject nextSlide;
    public TextMeshPro tm;

    public GameObject redTile;
    public GameObject greenTile;
    public GameObject yellowTile;
    public GameObject blueTile;
    public GameObject player;

    public GameObject switchTileText;
    private AudioSource source;
    public AudioClip next_sound;

    void Start()
    {
        source = GetComponent<AudioSource>();
        displaced = false;
        if (tileReset == true)
        {
            redTile.SetActive(true);
            greenTile.SetActive(true);
            yellowTile.SetActive(true);
            blueTile.SetActive(true);
            displacement(0);

        }


        //Invoke("callNextSlide", timer);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer >= 0)
        {
            if((Mathf.RoundToInt(timer) == 7) && (displaced == false)&&(tileReset == true))
            {
                int rand = Random.Range(0, 4);
                displacement(rand);
                switchTileText.SetActive(true);
                Invoke("DisableText", 0.5f);
                SoundManager.PlaySound("Warning SFX");
                displaced = true;
            } else if (Mathf.RoundToInt(timer) == 7)
            {

            } else if ((Mathf.RoundToInt(timer) == 3) && (displaced == false) && (tileReset == true))
            {
                int rand = Random.Range(0, 4);
                displacement(rand);
                switchTileText.SetActive(true);
                Invoke("DisableText", 0.5f);
                SoundManager.PlaySound("Warning SFX");
                displaced = true;
            }
            else if (Mathf.RoundToInt(timer) == 3)
            {

            } else
            {
                displaced = false;
            }
            
            //tm.text = timer.ToString();
            tm.GetComponent<TextMeshPro>().text = "Slide timer : " + Mathf.RoundToInt(timer).ToString();
        }
        else
        {
            //Otherwise display this
            tm.GetComponent<TextMeshPro>().text = "Time is up!";
            if(isQuestion == true)
            { 
                tileRemoval(correctTile);
                //Debug.Log(player.transform.position.y);
                
            }
            callNextSlide();
        }
    }
    void DisableText()
    {
        switchTileText.SetActive(false);
    }
    public void displacement(int tilePattern)
    {
        
        //tiles_1.GetComponent<Transform>().position = new Vector3(-8.635223f, -5.610151f, -11.37794f);
        switch (tilePattern)
        {
            case 0:     
                redTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 7.412537f);
                greenTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 18.95224f);
                yellowTile.GetComponent<Transform>().position = new Vector3(10.90778f, -2.415052f, 7.412537f);
                blueTile.GetComponent<Transform>().position = new Vector3(10.92178f, -2.415052f, 18.95224f);
                break;

            case 1:
                greenTile.GetComponent<Transform>().position = new Vector3(10.92178f, -2.415052f, 18.95224f);
                redTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 18.95224f);
                yellowTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 7.412537f);
                blueTile.GetComponent<Transform>().position = new Vector3(10.90778f, -2.415052f, 7.412537f);
                break;

            case 2:
                yellowTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 18.95224f);
                greenTile.GetComponent<Transform>().position = new Vector3(10.90778f, -2.415052f, 7.412537f);
                redTile.GetComponent<Transform>().position = new Vector3(10.92178f, -2.415052f, 18.95224f);
                blueTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 7.412537f);
                break;

            case 3:
                blueTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 18.95224f);
                greenTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 7.412537f);
                yellowTile.GetComponent<Transform>().position = new Vector3(10.92178f, -2.415052f, 18.95224f);
                redTile.GetComponent<Transform>().position = new Vector3(10.90778f, -2.415052f, 7.412537f);
                break;


            default:
                redTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 7.412537f);
                greenTile.GetComponent<Transform>().position = new Vector3(-0.6772232f, -2.415052f, 18.95224f);
                yellowTile.GetComponent<Transform>().position = new Vector3(10.90778f, -2.415052f, 7.412537f);
                blueTile.GetComponent<Transform>().position = new Vector3(10.92178f, -2.415052f, 18.95224f);
                break;
        }

    }
    
    public void callNextSlide()
    {

        nextSlide.SetActive(true);
        Destroy(thisSlide);
        

    }

    public void tileRemoval(int correctAnswer)
    {
        switch (correctAnswer)
        {
            case 0:                
                // red tile is correct
                greenTile.SetActive(false);
                yellowTile.SetActive(false);
                blueTile.SetActive(false);
                break;

            case 1:
                // green tile is correct}
                redTile.SetActive(false);
                yellowTile.SetActive(false);
                blueTile.SetActive(false);
                break;

            case 2:
                // yellow tile is correct
                greenTile.SetActive(false);
                redTile.SetActive(false);
                blueTile.SetActive(false);
                break;

            case 3:
                // blue tile is correct
                greenTile.SetActive(false);
                yellowTile.SetActive(false);
                redTile.SetActive(false);
                break;


            default:
                redTile.SetActive(false);
                greenTile.SetActive(false);
                yellowTile.SetActive(false);
                blueTile.SetActive(false);
                break;
        }
    }
}
