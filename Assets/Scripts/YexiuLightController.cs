using UnityEngine;
using System.Collections;

public class YexiuLightController : MonoBehaviour {

    public float maxSpeed = 3f;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
