using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidade : MonoBehaviour
{
    public float Speed = .1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Speed += .025f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Speed -= .025f;
            if(Speed < 0)
            {
                Speed = 0;
            }
        }

        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * Speed;

    }
}
