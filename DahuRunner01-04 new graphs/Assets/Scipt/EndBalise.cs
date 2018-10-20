using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBalise : MonoBehaviour {

	private StateManager statemanager;


	// Use this for initialization
	void Start () {
		statemanager = GameObject.FindObjectOfType<StateManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.tag == "Player")
		{
			statemanager.WinLevel ();
		}
	}
}
