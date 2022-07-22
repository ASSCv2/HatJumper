using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 1000 * Time.deltaTime, 0);
        }

       // if (Input.GetKey("shift"))
       // {
    //     transform.localScale = new Vector3 (x, y, z);
       // }
    }
}
