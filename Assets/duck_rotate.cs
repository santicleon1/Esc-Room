using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck_rotate : MonoBehaviour
{
    public SpriteRenderer sprite;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (rb.velocity.x < 0)
        {
           sprite.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            sprite.flipX = false;
        }
    }
}
