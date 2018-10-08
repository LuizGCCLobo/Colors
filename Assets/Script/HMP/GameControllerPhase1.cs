using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerPhase1 : MonoBehaviour {

	public GameObject boss;
	public float timer;
	public float bossSpawntime;
	public Text gameOverText;
	public bool canIGoHomeNow;

	public int pWCounter;
	public int pWRandom;
	public GameObject powerUpFire;
	public GameObject powerUpSpeed;

	AudioSource GCSource;
	public AudioClip enemyDeath;
	// Use this for initialization
	void Start () {
		canIGoHomeNow = false;
		Time.timeScale = 1;
		timer = 0f;
		boss.gameObject.SetActive (false);
		gameOverText.gameObject.SetActive (false);
		pWCounter = 0;
		GCSource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		SetBoss ();

		Reset ();

		PWInstance ();

	}

	void SetBoss(){
		if (timer > bossSpawntime) {
			boss.gameObject.SetActive (true);
		}
	}

	void GameOver(){
		canIGoHomeNow = true;
		Time.timeScale = 0;
	}
	void Reset(){
		if (canIGoHomeNow) {
			gameOverText.gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Main2");
			}
		}
	}

	void Win(){
		SceneManager.LoadScene ("Cutscene02");
	}

	void PWCounter(){
		pWCounter++;
	}

	void PWInstance(){
		if (pWCounter >= 10) {
			pWRandom = Random.Range (1, 11);
			if (pWRandom == 1 || pWRandom == 3 || pWRandom == 5 || pWRandom == 7 || pWRandom == 9) {
				Instantiate (powerUpFire, transform.position, transform.rotation);
			}
			if (pWRandom == 2 || pWRandom == 4 || pWRandom == 6 || pWRandom == 8 || pWRandom == 10) {
				Instantiate (powerUpSpeed, transform.position, transform.rotation);
			}
			pWCounter = 0;
		}
	}

	void PlayEnemyDeath(){
		GCSource.PlayOneShot (enemyDeath, 0.02f);
	}

}