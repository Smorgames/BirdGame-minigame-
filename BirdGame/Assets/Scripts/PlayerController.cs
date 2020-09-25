using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;

    [SerializeField] private float _yPositionTopLimit;
    [SerializeField] private float _yPositionBotLimit;

    private Rigidbody2D _rigidBody;
    private Vector2 _movement;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement.y = Input.GetAxisRaw("Vertical");

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, _yPositionBotLimit, _yPositionTopLimit));
    }

    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _movement * _playerSpeed * Time.fixedDeltaTime);
    }
}
