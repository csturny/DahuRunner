using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour {

	public GameObject Camera;
	public GameObject Player;

	public GameObject LayerSky;
	public GameObject Layer100;
	public GameObject Layer80;

	private float playerStartPosition;
	private float layerSkyStartPosition;
	private float layer100StartPosition;
	private float layer80StartPosition;



	/*
	private float posDeltaLayerSky;
	private float posDeltaLayer100;
	private float posDeltaLayer80;
	*/

	// Use this for initialization
	void Start () {
		/*
		posDeltaLayerSky = LayerSky.transform.position.x - transform.position.x;
		posDeltaLayer100 = Layer100.transform.position.x - transform.position.x;
		posDeltaLayer80 = Layer80.transform.position.x - transform.position.x;
		*/
		playerStartPosition = Player.transform.position.x;
		layerSkyStartPosition = LayerSky.transform.position.x;
		layer100StartPosition = Layer100.transform.position.x;
		layer80StartPosition = Layer80.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		float playerPosition = Player.transform.position.x;
		float layerSkyPosition = LayerSky.transform.position.x;
		float layer100Position = Layer100.transform.position.x;
		float layer80Position = Layer80.transform.position.x;

		//Vector3 pos = transform.position;

		LayerSky.transform.position = new Vector3 (playerPosition - playerStartPosition + layerSkyStartPosition, LayerSky.transform.position.y, LayerSky.transform.position.z);
		Layer100.transform.position = new Vector3 ((playerPosition - playerStartPosition)*0.88f + layer100StartPosition, LayerSky.transform.position.y, LayerSky.transform.position.z);
		Layer80.transform.position = new Vector3 ((playerPosition - playerStartPosition)*0.78f + layer80StartPosition, LayerSky.transform.position.y, LayerSky.transform.position.z);


	}
}
