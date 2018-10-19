using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour {

	public int nbrLives;
	public GameObject menuOver;
	public GameObject wonDisplay;

	public Button buttonStartAgain;
	public Button buttonQuit;

	private int Lives;


	// Use this for initialization
	void Start () {
		menuOver.SetActive (false);
		wonDisplay.SetActive (false);
		Lives = nbrLives;

		buttonStartAgain.onClick.AddListener (OnClickStartAgain);
		buttonQuit.onClick.AddListener (OnClickQuit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LostLife()
	{
		Lives = Lives - 1;
		if (IsLost ()) {
			print ("gameover");
			GameOver ();

		}
	}

	public bool IsLost()
	{
		if (Lives <= 0) {
			return true;
		} else {
			return false;
		}
	}

	public void GameOver()
	{
		menuOver.SetActive (true);
	}

	public void WinLevel()
	{
		menuOver.SetActive (true);
		wonDisplay.SetActive (true);
	}

	void OnClickStartAgain()
	{
		SceneManager.LoadScene ("main");
	}

	void OnClickQuit()
	{
		Application.Quit ();
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}
