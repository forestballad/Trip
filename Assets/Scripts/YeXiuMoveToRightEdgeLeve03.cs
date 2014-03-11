using UnityEngine;
using System.Collections;

public class YeXiuMoveToRightEdgeLeve03 : MonoBehaviour {
    public float maxSpeed = 2f;

    void FixedUpdate() {
        int move = 1;
        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
    }
}
