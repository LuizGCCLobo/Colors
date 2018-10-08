using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3Behaviour : MonoBehaviour {

	float timer;
	float timer2;

	public float fireRate;
	public float fireRate2;

	public GameObject LaserGun;
	public Transform LGSpawner;
	public GameObject LaserBGun;
	public Transform LGBSpawner;

	public bool dmg1;
	public bool dmg2;

	public float life;

	public float timerDMG1;
	public float TimerDMG2;

	public float Seila;

	GameObject GC;

	// Use this for initialization
	void Start () {
		timer = 0f;
		timer2 = 0f;

		dmg1 = false;
		dmg2 = false;

		timerDMG1 = 0f;
		TimerDMG2 = 0f;

		GC = GameObject.FindGameObjectWithTag ("GameController");

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;

		Fire ();
		Fire2 ();

		KillThisBitch ();

		if (dmg1) {
			timerDMG1 += Time.deltaTime;
		}
		if (timerDMG1 >= Seila) {
			dmg1 = false;
			timerDMG1 = 0f;
		}
		if (dmg2) {
			TimerDMG2 += Time.deltaTime;
		}
		if (TimerDMG2 >= Seila) {
			dmg2 = false;
			TimerDMG2 = 0f;
		}
	}

	void Fire (){
		if (timer > fireRate) {
			Instantiate (LaserGun, LGSpawner.transform.position, LGSpawner.transform.rotation);
			timer = 0f;

		}
	}

	void Fire2(){
		if (timer2 > fireRate2) {
			Instantiate (LaserBGun, LGBSpawner.transform.position, LGBSpawner.transform.rotation);
			timer2 = 0f;

		}
	}

	void ApplyDamage1 (bool apply){
		if (apply) {
			dmg1 = true;
		}
	}

	void ApplyDamage2 (bool apply2){
		if (apply2) {
			dmg2 = true;
		}
	}

	void KillThisBitch(){
		if (dmg1 && dmg2) {
			life--;
		}

		if (life <= 0) {
			GC.SendMessage ("Win");
			gameObject.SetActive (false);
		}
	}
}
