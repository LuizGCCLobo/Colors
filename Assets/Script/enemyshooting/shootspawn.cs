using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootspawn : MonoBehaviour {

	public float shoottime;
	public GameObject enemyattack;
	public Transform shootorigin;
	public float shootspeed;

	// Use this for initialization
	void Start () {

		shoottime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		shoottime += Time.deltaTime;

		shootpoint ();
	}

	void shootpoint(){

		if (shoottime > shootspeed) {
			
			Instantiate (enemyattack, shootorigin.position, shootorigin.rotation);
			shoottime = 0f;
		
		}
	}
}
