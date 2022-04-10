using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float timer = 40.5f;
    public GameObject player;
    public TextMeshProUGUI prizeText;
    private int currentPrize;
    private int prizeToAdd = 500000;
    private void Start()
    {
        currentPrize = 0;
        prizeText.text = "Prize: 0";
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if(player.transform.position.y > -1.5)
            {
                currentPrize += prizeToAdd;
                prizeText.text = "Prize: " + currentPrize + "$";
                timer = 15.5f;
            }
        }
    }
}
