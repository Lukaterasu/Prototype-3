using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollingBall : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 50f;
    private GameObject player;
    private float timer = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("PlayerCapsule");
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        rb.AddForce((player.transform.position - transform.position).normalized * speed);
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            rb.AddForce((transform.position - player.transform.position).normalized * speed, ForceMode.Impulse);
        }
    }

}
