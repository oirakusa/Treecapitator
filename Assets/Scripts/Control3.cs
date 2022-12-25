using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control3 : MonoBehaviour
{
    public float speed;

    private Animator anim;
    private float _walkTime = 0, _walkCooldown = 0.2f;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunLeft", true);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("RunUp", true);
        }
        else
        {
            anim.SetBool("RunUp", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("RunDown", true);
        }
        else
        {
            anim.SetBool("RunDown", false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}