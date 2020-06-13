﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public PlayerEventsController controller;
    public Animator animator;

    public float runSpeed = 80f;
    
    float horizontalMove = 0f; 
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
           jump = true;
           animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch")) 
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch")) 
        {
            crouch = false;
        
        }
    }

    void FixedUpdate () {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(-15,-2, 0);
    }

}
