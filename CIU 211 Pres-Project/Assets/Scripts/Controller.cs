using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;
    private float x,Force,MaxSpeed;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();		
	}

    private void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
        transform.LookAt(transform.position, rb.velocity);

    }
    // Update is called once per frame
    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        if(x < 0)
        {
            rb.AddForce(Vector3.right * Force);
        }
        if(x > 0)
        {
            rb.AddForce(Vector3.left * Force);
        }
        if ( x == 0)
        {
            rb.velocity = Vector3.zero;
        }
	}
}
