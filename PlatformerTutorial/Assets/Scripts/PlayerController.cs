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

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        //left == -1, right == 1;

        //rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y) + rb.position * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpSpeed) + rb.position * Time.deltaTime;
            isGrounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }
}
