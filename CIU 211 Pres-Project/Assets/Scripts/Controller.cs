using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;
    public float x,Force,MaxSpeed;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        x = anim.GetFloat("xPos");
	}

    private void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
        transform.LookAt(transform.position + rb.velocity);
        //anim.SetFloat("xPos", x);

    }
    // Update is called once per frame
    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("xPos", x);
        if(x < 0)
        {
            rb.AddForce(Vector3.left * Force);
            anim.SetBool("isWalking", true);

        }
        if(x > 0)
        {
            rb.AddForce(Vector3.right * Force);
            anim.SetBool("isWalking", true);
        }
        if ( x == 0)
        {
            rb.velocity = Vector3.zero;
            anim.SetBool("isWalking", false);
        }
	}
}
