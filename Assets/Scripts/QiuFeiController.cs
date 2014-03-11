using UnityEngine;
using System.Collections;

public class QiuFeiController : MonoBehaviour
{

    public float maxSpeed = 3f;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 400f;
	
    void Update(){
        if (grounded && Input.GetKeyDown(KeyCode.Space)){
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
        }
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);


        float move = Input.GetAxis("Horizontal");

        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
    }
}
