using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviourOne : MonoBehaviour {

	public GameObject enemy;
	public float timer;
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
	public float spawnTime13;
	public float spawnTime14;
	public float spawnTime15;

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
	bool Spawn13;
	bool Spawn14;
	bool Spawn15;

	// Use this for initialization
	void Start () {

		timer = 0f;
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
		Spawn13 = true;
		Spawn14 = true;
		Spawn15 = true;

	}

	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		Spawn ();
	}

	void Spawn(){

		if (timer > spawnTime && Spawn1 == true) {

			if (timer > spawnTime) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn1 = false;

			}

		}

		if (timer > spawnTime2 && Spawn2 == true) {

			if (timer > spawnTime2) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn2 = false;
			}

		}

		if (timer > spawnTime3 && Spawn3 == true) {

			if (timer > spawnTime3) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn3 = false;
			}

		}

		if (timer > spawnTime4 && Spawn4 == true) {

			if (timer > spawnTime4) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn4 = false;
			}

		}

		if (timer > spawnTime5 && Spawn5 == true) {

			if (timer > spawnTime5) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn5 = false;
			}

		}

		if (timer > spawnTime6 && Spawn6 == true) {

			if (timer > spawnTime6) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn6 = false;
			}

		}

		if (timer > spawnTime7 && Spawn7 == true) {

			if (timer > spawnTime7) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn7 = false;
			}

		}

		if (timer > spawnTime8 && Spawn8 == true) {

			if (timer > spawnTime8) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn8 = false;
			}

		}

		if (timer > spawnTime9 && Spawn9 == true) {

			if (timer > spawnTime9) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn9 = false;
			}

		}

		if (timer > spawnTime10 && Spawn10 == true) {

			if (timer > spawnTime10) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn10 = false;
			}

		}

		if (timer > spawnTime11 && Spawn11 == true) {

			if (timer > spawnTime11) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn11 = false;
			}

		}

		if (timer > spawnTime12 && Spawn12 == true) {

			if (timer > spawnTime12) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn12 = false;
			}

		}

		if (timer > spawnTime13 && Spawn13 == true) {

			if (timer > spawnTime13) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn13 = false;
			}

		}

		if (timer > spawnTime14 && Spawn14 == true) {

			if (timer > spawnTime14) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn14 = false;
			}

		}

		if (timer > spawnTime15 && Spawn15 == true) {

			if (timer > spawnTime15) {
				Instantiate (enemy, transform.position, transform.rotation);
				Spawn15 = false;
			}

		}

	}

}
