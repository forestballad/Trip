using UnityEngine;
using System.Collections;

public class YexiuLightController : MonoBehaviour {

    public float maxSpeed = 3f;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
    }
}
