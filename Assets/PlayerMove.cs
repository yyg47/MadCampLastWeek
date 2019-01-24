﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float distance = 0.5f;
    //public bool Right;
    //public bool Left;
    //public bool Up;
    //public bool Down;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        animator.SetBool("Right", false);
        animator.SetBool("Left", false);
        animator.SetBool("Up", false);
        animator.SetBool("Down", false);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, distance, 0);
            animator.SetBool("Up", true);
            //rb.AddForce(0, forcemovement * Time.deltaTime, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -distance, 0);
            animator.SetBool("Down", true);
            //rb.AddForce(0, -forcemovement * Time.deltaTime, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(distance, 0, 0);
            animator.SetBool("Right", true);
            //rb.AddForce(forcemovement * Time.deltaTime, 0, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-distance, 0, 0);
            animator.SetBool("Left", true);
            //rb.AddForce(-forcemovement * Time.deltaTime, 0, 0, ForceMode.Force);
        }

        
    }
}
