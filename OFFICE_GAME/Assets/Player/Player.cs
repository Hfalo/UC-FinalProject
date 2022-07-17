using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    Vector2 movement; // stores x and y

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update() // input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate() // movement

    {
        rb.velocity = movement * speed;
        
    }


}

