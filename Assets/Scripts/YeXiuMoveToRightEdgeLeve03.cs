using UnityEngine;
using System.Collections;

public class YeXiuMoveToRightEdgeLeve03 : MonoBehaviour {
    public float maxSpeed = 2f;

    void FixedUpdate() {
        int move = 1;
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
