using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	public Transform PlayerTransform;

	public float moveSpeed = 4f;
	private Rigidbody2D myRigidbody;

	private Vector3 cameraPosDelta;
	private float cameraPosDeltaX;
	public Vector3 translateHitObstacle;
	private Vector3 statePosition;


	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
		cameraPosDelta = new Vector3(PlayerTransform.position.x - transform.position.x,0,0);
		cameraPosDeltaX = PlayerTransform.position.x - transform.position.x;
		statePosition = new Vector2 ();

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = new Vector3 (PlayerTransform.position.x, transform.position.y, transform.position.z);


		pos = pos - cameraPosDelta + statePosition;
		Vector3 pos2D = new Vector3 (pos.x, pos.y, -10);
		transform.position = pos2D;


		//Vector3 pos = new Vector3 (PlayerTransform.position.x, trans

	}

	public void HitObstacle()
	{
		statePosition = statePosition - translateHitObstacle;
	}
}
