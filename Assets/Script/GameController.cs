using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject boss;
	public float timer;
	public float bossSpawntime;
	public Text gameOverText;
	public bool canIGoHomeNow;
	public bool bossIsTrue;

	//textsingame
	public GameObject textBox;
	public Text text1;
	public Text text2;
	public Text text3;
	public Text text4;
	public Text text5;
	public float textSpawnTime1;
	public float textSpawnTime2;
	public float textSpawnTime3;
	public float textSpawnTime4;
	public float textSpawnTime5;
	public AudioClip line1;
	public AudioClip line2;
	public AudioClip line3;
	bool Sound1;
	bool Sound2;
	bool Sound3;

	public float timerText;

	AudioSource GCSource;
	public AudioClip enemyDeath;
	// Use this for initialization
	void Start () {
		canIGoHomeNow = false;
		Time.timeScale = 1;
		timer = 0f;
		timerText = 0f;
		boss.gameObject.SetActive (false);
		gameOverText.gameObject.SetActive (false);
		bossIsTrue = false;
		GCSource = GetComponent<AudioSource> ();

		text1.gameObject.SetActive (false);
		text2.gameObject.SetActive (false);
		text3.gameObject.SetActive (false);
		text4.gameObject.SetActive (false);
		text5.gameObject.SetActive (false);
		textBox.gameObject.SetActive (false);

		Sound1 = true;
		Sound2 = true;
		Sound3 = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timerText += Time.deltaTime;
		SetBoss ();

		Reset ();

		TextController ();
		
	}

	void SetBoss(){
		if (timer > bossSpawntime) {
			boss.gameObject.SetActive (true);
			bossIsTrue = true;
		}
	}

	void GameOver(){
		canIGoHomeNow = true;
		Time.timeScale = 0;
	}
	void Reset(){
		if (canIGoHomeNow && bossIsTrue==false) {
			gameOverText.gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Main");
			}
		}
		if (canIGoHomeNow && bossIsTrue) {
			gameOverText.gameObject.SetActive (true);
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Cutscene01");
			}
		}
	}
	void PlayEnemyDeath(){
		GCSource.PlayOneShot (enemyDeath, 0.02f);
	}

	void TextController(){
		if (timerText > textSpawnTime1 && Sound1) {
			text1.gameObject.SetActive (true);
			textBox.gameObject.SetActive (true);
			GCSource.PlayOneShot (line1, 1f);
			Sound1 = false;
		}
		if (timerText > textSpawnTime2 && Sound2) {
			text1.gameObject.SetActive (false);
			text2.gameObject.SetActive (true);
			GCSource.PlayOneShot (line2, 1f);
			Sound2 = false;
		}
		if (timerText > textSpawnTime3 && Sound3) {
			text2.gameObject.SetActive (false);
			text3.gameObject.SetActive (true);
			GCSource.PlayOneShot (line3, 1f);
			Sound3 = false;
		}
		if (timerText > textSpawnTime4) {
			text3.gameObject.SetActive (false);
			text4.gameObject.SetActive (true);
		}
		if (timerText > textSpawnTime5) {
			text4.gameObject.SetActive (false);
			text5.gameObject.SetActive (true);
		}
		if (timerText > textSpawnTime5 + 2) {
			text5.gameObject.SetActive (false);
			textBox.gameObject.SetActive (false);
		}
	}

}
