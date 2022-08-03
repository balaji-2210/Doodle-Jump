using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float jump = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 bounce = rb.velocity;
                bounce.y = jump;
                rb.velocity = bounce;
            }
        }
        
    }
}
