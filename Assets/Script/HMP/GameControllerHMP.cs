using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerHMP : MonoBehaviour {

	public Text gameOverText;
	bool canIGoHomeNow;

	// Use this for initialization
	void Start () {

		gameOverText.gameObject.SetActive (false);
		Time.timeScale = 1;
		canIGoHomeNow = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		Reset ();
	}

	void Win(){
		SceneManager.LoadScene ("Cutscene04");
	}

	void GameOver(){
		canIGoHomeNow = true;
		Time.timeScale = 0;
	}

	void Reset(){
		if (canIGoHomeNow) {
			gameOverText.gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("MainBoss3");
			}
		}
	}
}
