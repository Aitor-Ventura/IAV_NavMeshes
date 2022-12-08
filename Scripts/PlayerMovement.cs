using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12f;
    
    private CharacterController controller;
    private bool isGrounded;
    private Vector3 velocity;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>().GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");;

        controller.Move(move * (speed * Time.deltaTime));

        velocity.y -= Physics.gravity.magnitude * Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);
    }
}