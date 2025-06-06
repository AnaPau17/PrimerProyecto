using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 4f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isGrounded;
    private Animator animator; // reference to Animator

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // get Animator component
    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");

        // Play "Playerrun_Right" animation if D or RightArrow is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetTrigger("Run_R");
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            isGrounded = true;
        }
    }
}
