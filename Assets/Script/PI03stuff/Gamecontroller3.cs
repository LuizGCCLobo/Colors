using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller3 : MonoBehaviour {

	float timer;
	public float Phase;
	float EndPhase;
	public float Phase2;
	float EndPhase2;
	public GameObject Portal;
	public GameObject LPortal1;
	public GameObject LPortal2;
	public GameObject LPortal3;
	public GameObject LPortal4;
	public GameObject Boss3;
	public float timerLaser;
	public GameObject Lportal5;


	// Use this for initialization
	void Start () {
		timer = 0f;
		EndPhase = Phase + 4;
		EndPhase2 = Phase2 + 4;
		Portal.SetActive (false);
		LPortal1.SetActive (false);
		LPortal2.SetActive (false);
		LPortal3.SetActive (false);
		LPortal4.SetActive (false);
		Boss3.SetActive(false);
		Lportal5.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > Phase && timer < EndPhase) {
			Portal.SetActive (true);
		} else {
			Portal.SetActive (false);
		}
		if (timer > Phase2 && timer < EndPhase2) {
			Boss3.SetActive (true);
			LPortal1.SetActive (true);
			LPortal2.SetActive (true);
			LPortal3.SetActive (true);
			LPortal4.SetActive (true);
		}
		if (timer > timerLaser) {
			Lportal5.SetActive (true);
		}
	}

}
