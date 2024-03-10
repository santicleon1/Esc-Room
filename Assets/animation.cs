using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    private float rbax;
    private float rbay;
    private bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            grounded = false;
        }
    }
    void Update()
    {
        rbax = Math.Abs(rb.velocity.x);
        rbay = Math.Abs(rb.velocity.y);

        if (grounded == true)
        {
            animator.SetBool("move", false);
        }

        else if (rbax > 0 || rbay > 0)
        {
            animator.SetBool("move", true);
        }

        else
        {
           animator.SetBool("move", false); 
        }
    }
}
