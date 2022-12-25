using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2 : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer sprite;

    [SerializeField]
    int speed;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            anim.SetBool("RunLeft", true);

        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            anim.SetBool("RunUp", true);
        }
        else
        {
            anim.SetBool("RunUp", false);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
            anim.SetBool("RunDown", true);
        }
        else
        {
            anim.SetBool("RunDown", false);
        }
     
    }

}