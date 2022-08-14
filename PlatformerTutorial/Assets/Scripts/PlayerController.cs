using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector2 movement;
    // // x y
    public float jumpSpeed;
    public Rigidbody2D rb;
    public bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        //left == -1, right == 1;

        //rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        //rb.AddForce(movement * speed + rb.position * Time.deltaTime, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            isGrounded = false;
        }

        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
}
