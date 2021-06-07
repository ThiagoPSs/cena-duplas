using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torre : MonoBehaviour
{
    public float vel = 2f;
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotateChange);

        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(rotateChange * vel);
        }
    }
}
