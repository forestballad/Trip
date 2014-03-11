using UnityEngine;
using System.Collections;

public class QiuFeiControllerDJ : MonoBehaviour {
    public float maxSpeed = 3f;

    bool grounded = false;
    bool firstjump = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 450f;

    void Update()
    {
        if (grounded)
        {
            firstjump = false;
        }

        if (!firstjump && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
            firstjump = true;
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        float move = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
    }
}
