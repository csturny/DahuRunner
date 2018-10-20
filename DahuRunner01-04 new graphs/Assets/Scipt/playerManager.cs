using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	public groundDetector groundDetection;

	public Collider2D groundSensor;

	private Rigidbody2D myRigidbody;

	public bool grounded;
	private bool isLeavedGround = false;
	enum JumpState {GROUNDED, FIRSTJUMP, SECONDJUMP};
	private JumpState jumpState = JumpState.GROUNDED;


	public LayerMask whatIsGround;

	private Collider2D myCollider;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();

		myCollider = GetComponent<Collider2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		//grounded = Physics2D.IsTouchingLayers (groundSensor, whatIsGround);
		grounded = groundDetection.IsGrounded ();

		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);

		//print (transform.position);

		if (!isLeavedGround && !grounded) {
			isLeavedGround = true;				
		} else if (isLeavedGround && grounded) {
			jumpState = JumpState.GROUNDED;
			isLeavedGround = false;
		}

		if (jumpState == JumpState.GROUNDED)
		{
			if (grounded) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);
					jumpState = JumpState.FIRSTJUMP;
				}
			}
			if (isLeavedGround) {
				jumpState = JumpState.FIRSTJUMP;
			}
		}
		else if (jumpState == JumpState.FIRSTJUMP)
		{
			if (Input.GetKeyDown (KeyCode.Space)) {
				myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);
				jumpState = JumpState.SECONDJUMP;
			}
		}
		else if (jumpState == JumpState.SECONDJUMP)
		{

		}

		if (transform.position.y < -100f) {
			GameObject.FindObjectOfType<StateManager> ().GameOver ();
		}
	}
}
