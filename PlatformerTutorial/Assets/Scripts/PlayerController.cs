using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector2 movement;
    // // x y
    public Rigidbody2D rb;

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
        rb.AddForce(movement * speed + rb.position * Time.deltaTime);
    }
}
