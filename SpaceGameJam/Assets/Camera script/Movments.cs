using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movments : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;	
    public float sidewaysForce = 500f;
    public float maxTravelDistance = 100f;
    void FixedUpdate ()
    {
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (transform.position.x > (maxTravelDistance - 0.01f) && rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(rb.velocity.y, 0, 0);
        }
        if (transform.position.x < -(maxTravelDistance - 0.01f) && rb.velocity.x < 0)
        {
            rb.velocity = new Vector3(rb.velocity.y, 0, 0);
        }

        if (Input.GetKey("d"))	
        {
            if (transform.position.x < (maxTravelDistance - 0.01f))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            }
            
        }

        if (Input.GetKey("a"))  
        {
            if (transform.position.x > -(maxTravelDistance - 0.01f))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            }
        }
    }
}
