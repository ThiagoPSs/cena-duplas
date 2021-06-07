using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLEPERSONAGEM : MonoBehaviour
{
    CharacterController cont;

    Vector3 foward;
    Vector3 strafe;
    Vector3 vertical;

    float fowardSpeed = 5f;
    float strafeSpeed = 5f;

    float gravity;
    float jumpSpeed;
    float maxJumpHeight = 2f;
    float timeToMaxHeight = 0.5f;
    
    void Start()
    {
        cont = GetComponent<CharacterController>();

        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }

    void Update()
    {
        float fowardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        foward = fowardInput * fowardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        if (cont.isGrounded)
        {
            vertical = Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.Space) && cont.isGrounded)
            {
                vertical = jumpSpeed * Vector3.up;
            }   
       
        Vector3 finalVelocity = foward + strafe + vertical;

        cont.Move(finalVelocity * Time.deltaTime);

    }
}
