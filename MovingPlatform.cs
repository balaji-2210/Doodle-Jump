using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0f);
    }

    void Update()
    {
        if (transform.position.x >= 2)
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        else if (transform.position.x <= -2)
        {
            rb.velocity = new Vector2(speed, 0f);
        }
    }

}
