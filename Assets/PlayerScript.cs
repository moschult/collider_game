using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 100;

    public float sidewardsForce = 500;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewardsForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardsForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
    }

    void onCollisionEnter ()
    {

    }
}
