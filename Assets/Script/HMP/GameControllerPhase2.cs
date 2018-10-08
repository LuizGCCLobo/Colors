using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerPhase2 : MonoBehaviour {

	public Text gameOverText;
	public bool canIGoHomeNow;

	AudioSource GCSource;
	public AudioClip enemyDeath;

	public float timer;
	public float Spoiler;
	//public GameObject chromaShip;
	public GameObject gameOverSprite;
	// Use this for initialization
	void Start () {
		canIGoHomeNow = false;
		Time.timeScale = 1;
		gameOverText.gameObject.SetActive (false);
		GCSource = GetComponent<AudioSource> ();
		//chromaShip.gameObject.SetActive(false);
		timer = 0f;
		gameOverSprite.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		Reset ();

		//SpoilerController ();

		if (timer > 235) {
			SceneManager.LoadScene ("Cutscene035");
		}

	}

	void GameOver(){
		canIGoHomeNow = true;
		Time.timeScale = 0;
	}
	void Reset(){
		if (canIGoHomeNow) {
			gameOverText.gameObject.SetActive (true);
			gameOverSprite.gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Main3");
			}
		}
	}

	void PlayEnemyDeath(){
		GCSource.PlayOneShot (enemyDeath, 0.02f);
	}

	//void SpoilerController(){
		//if (timer > Spoiler) {
			//chromaShip.gameObject.SetActive (true);
		//}
	//}

}