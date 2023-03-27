using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D _rb;
    private float _colliderRange = 1.2f;

    private bool IsGrounded
    {
        get
        {
            // Check if the player is grounded by casting a ray down from the player
            return Physics2D.Raycast(transform.position, Vector2.down, _colliderRange, groundLayer);
        }
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        MoveCharacter(GetHorizontalInput());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private float GetHorizontalInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }
    
    private void MoveCharacter(float horizontalInput)
    {
        _rb.velocity = new Vector2(horizontalInput * speed, _rb.velocity.y);
    }

    private void Jump()
    {
        if (IsGrounded)
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        // Draw a raycast down from the player to check if they are grounded
        Gizmos.color = IsGrounded ? Color.green : Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.down * _colliderRange));
    }
}
