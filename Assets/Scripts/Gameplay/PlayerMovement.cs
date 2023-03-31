using DefaultNamespace;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    #region Members

    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 30f;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private float _colliderRange = 1.2f;
    private PlayerInteractions _playerInteractions;
    private PlayerAnimations _playerAnimations;
    private const float GRAVITY_SCALE = 10f;
    private const float FALLING_GRAVITY_SCALE = 40f;
    private const float MINIMUM_MAGNITUDE_VALUE = 0.01f;

    #endregion

    #region Properties

    private bool IsGrounded =>
        // Check if the player is grounded by casting a ray down from the player
        Physics2D.Raycast(transform.position, Vector2.down, _colliderRange, groundLayer);

    #endregion

    #region Unity Methods
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerInteractions ??= new PlayerInteractions();
        _playerAnimations ??= new PlayerAnimations(GetComponent<Animator>());
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneLoader.LoadMainMenu();
        }

        _playerAnimations.SetIsWalking(_rb.velocity.magnitude > MINIMUM_MAGNITUDE_VALUE);
        _playerAnimations.SetIsJumping(!IsGrounded);

        HandleGravitation();
    }
    
    private void OnDrawGizmos()
    {
        // Draw a raycast down from the player to check if they are grounded
        Gizmos.color = IsGrounded ? Color.green : Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.down * _colliderRange));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Interact(col);
    }

    #endregion


    #region Private Methods

    private float GetHorizontalInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }
    
    private void MoveCharacter(float horizontalInput)
    {
        if(horizontalInput > 0)
            _spriteRenderer.flipX = false;
        else if(horizontalInput < 0)
            _spriteRenderer.flipX = true;
        
        _rb.velocity = new Vector2(horizontalInput * speed, _rb.velocity.y);
    }
    
    private void Jump()
    {
        if (IsGrounded)
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            
            if(AudioManager.Instance != null)
                AudioManager.Instance.PlaySfx(AudioManager.Sfx.Jump);
        }
    }


    private void HandleGravitation()
    {
        if(_rb.velocity.y >= 0)
        {
            _rb.gravityScale = GRAVITY_SCALE;
        }
        else if (_rb.velocity.y < 0)
        {
            _rb.gravityScale = FALLING_GRAVITY_SCALE;
        }
    }

    private void Interact(Collider2D collider2D)
    {
        _playerInteractions.TryInteracting(collider2D);
    }

    #endregion

}
