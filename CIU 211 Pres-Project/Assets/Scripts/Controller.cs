using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;
    public float x,z,Force,MaxSpeed,RotationForce;
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        x = anim.GetFloat("xPos");
        z = anim.GetFloat("zPos");
    }

    private void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
        rb.angularVelocity = Vector3.zero;
        //transform.LookAt(transform.position + rb.velocity);
        //anim.SetFloat("xPos", x);

    }
    // Update is called once per frame
    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        anim.SetFloat("xPos", x);
        anim.SetFloat("zPos", z);
        if (z > 0f)
        {
            rb.AddForce(transform.forward * Force);
            anim.SetBool("isWalking", true);
        }

        if (z < 0f)
        {
            rb.AddForce(transform.forward * -Force);
            anim.SetBool("isWalking", true);
        }

        if (x < 0)
        {
            //rb.AddForce(-transform.right * RotationForce);
            transform.Rotate(new Vector3(0f, -RotationForce, 0f));
            anim.SetBool("isWalking", true);

        }

        if(x > 0)
        {
            transform.Rotate(new Vector3(0f, RotationForce, 0f));
            anim.SetBool("isWalking", true);
        }

        if (z == 0)
        {
            rb.velocity = Vector3.zero;
        }

        if ( x == 0 && z == 0 )
        {
            anim.SetBool("isWalking", false);
        }
	}
}
