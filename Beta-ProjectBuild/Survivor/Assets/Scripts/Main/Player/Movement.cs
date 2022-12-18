using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
	private Rigidbody2D rigidbody;
	private Vector2 movementInput;
	
	public float speed;
	
	private void Awake()
	{
	rigidbody = GetComponent<Rigidbody2D>();
	}
	
	private void FixedUpdate()
	{
		rigidbody.velocity = movementInput * speed;
	
	}
	
	private void OnMove(InputValue inputValue)
	{
		movementInput = inputValue.Get<Vector2>();
	}
}