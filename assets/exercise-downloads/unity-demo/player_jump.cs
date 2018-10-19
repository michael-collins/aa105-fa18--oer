using UnityEngine;
using System.Collections;

public class player_jump : MonoBehaviour {

	public float jumpForce = 300f;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public bool grounded = false;
	public LayerMask whatIsGround;

	void FixedUpdate(){

		bool jump = Input.GetButtonDown("Jump");

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		if(jump && grounded) GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
	}
}
