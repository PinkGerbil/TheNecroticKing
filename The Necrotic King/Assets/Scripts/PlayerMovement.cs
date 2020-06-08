using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0,0,10));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -10));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-10, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(10, 0, 0));
        }
    }
}
