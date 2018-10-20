using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundDetector : MonoBehaviour {

	private bool isGrounded = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "Ground") {
			isGrounded = true;
		}
	}
	*/

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.tag == "Ground") {
			isGrounded = false;
		}
	}

	void OnTriggerStay2D ( Collider2D coll)
	{
		if (coll.tag == "Ground") {
			isGrounded = true;
		}
	}

	public bool IsGrounded()
	{
		return isGrounded;
	}
}
