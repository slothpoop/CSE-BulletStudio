using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private float _speed;

	private Rigidbody2D _rigidbody; 
	private Vector2 _movementInput;
	private Vector2 _smoothedMovementInput;
	private Vector2 _movementInputSmoothVelocity;

    public HealthBar healthBar;

    private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		_smoothedMovementInput = Vector2.SmoothDamp(
			_smoothedMovementInput,
			_movementInput,
			ref _movementInputSmoothVelocity,
			0.1f);

			 
		_rigidbody.velocity = _smoothedMovementInput * _speed;
	}

	private void OnMove(InputValue inputValue)
	{
		_movementInput = inputValue.Get<Vector2>();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Damage") ;
        {
            healthBar.Damage(0.02f);
        }
    }
}
