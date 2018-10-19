using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

	private cameraMove cameramove;
	private StateManager statemanager;

	// Use this for initialization
	void Start () {
		cameramove = GameObject.FindObjectOfType<cameraMove> ();
		statemanager = GameObject.FindObjectOfType<StateManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void destroy()
	{
		this.GetComponent<Animator>().SetBool ("isBeingDestroyed",true);
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.tag == "Player")
		{
			destroy();
			cameramove.HitObstacle ();
			statemanager.LostLife ();
		}
	}
}
