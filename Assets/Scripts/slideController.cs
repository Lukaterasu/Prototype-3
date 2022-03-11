using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class slideController : MonoBehaviour
{
    public bool tileReset = false;
    public bool isQuestion = false;
    public int correctTile;
    public float timer = 15;
    public GameObject thisSlide;
    public GameObject nextSlide;
    public TextMeshPro tm;

    public GameObject redTile;
    public GameObject greenTile;
    public GameObject yellowTile;
    public GameObject blueTile;


    // Start is called before the first frame update
    void Start()
    {
        if (tileReset == true)
        {
            redTile.SetActive(true);
            greenTile.SetActive(true);
            yellowTile.SetActive(true);
            blueTile.SetActive(true);
        }


        //Invoke("callNextSlide", timer);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer >= 0)
        {
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
            }
            callNextSlide();
        }
    }
    public void updateTimer()
    {


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
                // green tile is correct
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
