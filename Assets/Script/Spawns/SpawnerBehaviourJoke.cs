using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviourJoke : MonoBehaviour {

	public GameObject enemy;
	int sequence;
	public float timer;
	//public float timer2;
	public float spawnTime;
	public float spawnTime2;
	public float spawnTime3;
	public float spawnTime4;
	public float spawnTime5;
	public float spawnTime6;
	public float spawnTime7;
	public float spawnTime8;
	public float spawnTime9;
	public float spawnTime10;
	public float spawnTime11;
	public float spawnTime12;
	int formation;

	bool Spawn1;
	bool Spawn2;
	bool Spawn3;
	bool Spawn4;
	bool Spawn5;
	bool Spawn6;
	bool Spawn7;
	bool Spawn8;
	bool Spawn9;
	bool Spawn10;
	bool Spawn11;
	bool Spawn12;

	// Use this for initialization
	void Start () {

		timer = 0f;
		sequence = 1;
		//timer2 = 0f;
		Spawn1 = true;
		Spawn2 = true;
		Spawn3 = true;
		Spawn4 = true;
		Spawn5 = true;
		Spawn6 = true;
		Spawn7 = true;
		Spawn8 = true;
		Spawn9 = true;
		Spawn10 = true;
		Spawn11 = true;
		Spawn12 = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		//timer2 += Time.deltaTime;
		Spawn ();
	}

	void Spawn(){

		if (timer> spawnTime && Spawn1 == true) {

			if (timer > spawnTime + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;

			}
			if (formation >= 5) {
				formation = 0;
				Spawn1 = false;
				sequence = 0;
			}

		}

		if (timer > spawnTime2 && Spawn2 == true) {

			if (timer > spawnTime2 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn2 = false;
			}

		}

		if (timer > spawnTime3 && Spawn3 == true) {

			if (timer > spawnTime3 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn3 = false;
			}

		}

		if (timer > spawnTime4 && Spawn4 == true) {

			if (timer > spawnTime4 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn4 = false;
			}

		}

		if (timer > spawnTime5 && Spawn5 == true) {

			if (timer > spawnTime5 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn5 = false;
			}

		}

		if (timer > spawnTime6 && Spawn6 == true) {

			if (timer > spawnTime6 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn6 = false;
			}

		}

		if (timer > spawnTime7 && Spawn7 == true) {

			if (timer > spawnTime7 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn7 = false;
			}

		}

		if (timer > spawnTime8 && Spawn8 == true) {

			if (timer > spawnTime8 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn8 = false;
			}

		}

		if (timer > spawnTime9 && Spawn9 == true) {

			if (timer > spawnTime9 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn9 = false;
			}

		}

		if (timer > spawnTime10 && Spawn10 == true) {

			if (timer > spawnTime10 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn10 = false;
			}

		}

		if (timer > spawnTime11 && Spawn11 == true) {

			if (timer > spawnTime11 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn11 = false;
			}

		}

		if (timer > spawnTime12 && Spawn12 == true) {

			if (timer > spawnTime12 + sequence * 0.16f) {
				Instantiate (enemy, transform.position, transform.rotation);
				formation++;
				sequence++;
			}
			if (formation >= 5) {
				formation = 0;
				sequence = 0;
				Spawn12 = false;
			}

		}

	}

}
