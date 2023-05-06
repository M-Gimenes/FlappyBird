using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Bird : MonoBehaviour
{
    [SerializeField] float jumpForce;
    Vector3 mousePos;
    Rigidbody2D body;
    Animator anim;
    bool jumpPressed, death;

    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        death = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.y < 3.9f)
                jumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpPressed && !death)
        {
            FindObjectOfType<AudioManager>().Play("Jump");
            jumpPressed = false;
            body.velocity = new Vector2(0, 0);
            body.AddForce(new Vector2(0, jumpForce));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            body.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (!death)
        {
            FindObjectOfType<AudioManager>().Play("Hit");
            FindObjectOfType<AudioManager>().Play("Die");
            death = true;
            EventManager.Dead();
            anim.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 7)
        {
            FindObjectOfType<AudioManager>().Play("Point");
            EventManager.Scored();
        }
    }
}
