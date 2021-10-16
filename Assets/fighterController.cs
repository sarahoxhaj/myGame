using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighterController : MonoBehaviour
{

    private Animator anim;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    { 
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 5f, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 9f);
            anim.SetTrigger("jumping");
            anim.SetTrigger("falling");
        }
        
    }



   
}
