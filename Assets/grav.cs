using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grav : MonoBehaviour
{
    private CharacterController controller;

    public float verticalVelocity = 1;
    public float gravity = 15.0f;
    private float jumpForce;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
    
            }
        }


      else {
            verticalVelocity -= gravity * Time.deltaTime;

      }
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
    }
}

