﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController characterController; 
    Vector3 playerVel;
    float WalkSpeed = 8.0f;
    float gravity = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float XAxis = Input.GetAxis("Horizontal");
        float ZAxis = Input.GetAxis("Vertical");

        Vector3 move = transform.right * XAxis + transform.forward * ZAxis;
        characterController.Move(move * Time.deltaTime * WalkSpeed);


        //playerVel.y += gravity * Time.deltaTime;
        //characterController.Move(playerVel * Time.deltaTime);
    }
}
