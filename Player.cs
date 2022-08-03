using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public Text scoreText;
    
    public float movementSpeed = 10f;
    float movement;
    Rigidbody2D rb;



    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    { 
        transform.position = Vector2.zero;
        rb.velocity = Vector2.zero;
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        
        if(movement < 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if(movement > 0)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        if(collision.gameObject.tag == "Finish")
        {
            FindObjectOfType<GameManager>().WinGame();
        }
    }
}
