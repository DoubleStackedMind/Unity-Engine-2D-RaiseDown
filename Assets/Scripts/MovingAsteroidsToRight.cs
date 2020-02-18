using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAsteroidsToRight : MonoBehaviour {

    public Rigidbody2D rg;

    // Speed in units per sec.
    public float speed = 5f;
    private bool dirRight = true;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
    }
}
