using DefaultNamespace;
using UnityEngine;

public class Enemy : MonoBehaviour, IInteractable
{
    #region Member Variables

    [SerializeField] private Transform headPosition;
    [SerializeField] private LayerMask groundLayer;
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    private Vector3 _direction = Vector3.left;
    private float _enemySpeed = 6f;

    #endregion
    
    private bool IsGrounded => Physics2D.Raycast(headPosition.position, Vector3.down, 1f, groundLayer);
    
    #region Unity Events

    private void Awake()
    {
        _transform = transform;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        WalkThePlatform();
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = IsGrounded ? Color.green : Color.red;
        Gizmos.DrawRay(headPosition.position, Vector3.down);
    }

    #endregion

    #region Private Methods

    private void WalkThePlatform()
    {
        _transform.position += _direction * Time.deltaTime * _enemySpeed;
        CheckIfReachedEndOfPlatform();
    }
    
    private void CheckIfReachedEndOfPlatform()
    {
        if (IsGrounded) return;
        _direction *= -1;
        
        if (_spriteRenderer != null)
        {
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }
        
        headPosition.localPosition = new Vector3(headPosition.localPosition.x * -1, headPosition.localPosition.y, headPosition.localPosition.z);
    }

    #endregion

    #region Interface Implementations

    public void Interact()
    {
        SceneLoader.ReloadCurrentScene();
    }

    #endregion
}
