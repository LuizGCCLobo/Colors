using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Behaviour : MonoBehaviour {

	float x = 8f;
	public float speed;
	public Transform target;

	public float timer;

	public GameObject BossFire;
	public Transform BossFireSpawn;
	public Transform BossFireSpawn2;
	public Transform BossFireSpawn3;
	public Transform BossFireSpawn4;
	public Transform BossFireSpawn5;
	public Transform BossFireSpawn6;
	public Transform BossFireSpawn7;
	public Transform BossFireSpawn8;
	public Transform BossFireSpawn9;
	public Transform BossFireSpawn10;

	public bool Fire;

	float timefr;
	public float fireRate;
	GameObject JM;

	public float life;
	public float DamageTaken;

	GameObject GC;

	public int Shots;

	// Use this for initialization
	void Start () {
		JM = GameObject.FindGameObjectWithTag ("JawM");
		timer = 0f;
		timefr = 0f;
		Fire = false;
		Shots = 0;

		GC = GameObject.FindGameObjectWithTag ("GameController");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		timefr += Time.deltaTime;
		if (timer >= 2 && timer < 3) {
			Fire = true;
		} else {
			Fire = false;
		}
		if (Fire) {
			FireBoss ();
		}
		if (timer > 3) {
			timer = 0f;
		}
		JM.SendMessage ("Jaw", timer);
	}

	void MoveToPlayer(){
		transform.position = new Vector3 (x, target.position.y * speed * Time.deltaTime);
	}

	void FireBoss(){
		if (timefr > fireRate ) {
			Instantiate (BossFire, BossFireSpawn.transform.position, BossFireSpawn.transform.rotation);
			Instantiate (BossFire, BossFireSpawn2.transform.position, BossFireSpawn2.transform.rotation);
			Instantiate (BossFire, BossFireSpawn3.transform.position, BossFireSpawn3.transform.rotation);
			Instantiate (BossFire, BossFireSpawn4.transform.position, BossFireSpawn4.transform.rotation);
			Instantiate (BossFire, BossFireSpawn5.transform.position, BossFireSpawn5.transform.rotation);
			Instantiate (BossFire, BossFireSpawn6.transform.position, BossFireSpawn6.transform.rotation);
			Instantiate (BossFire, BossFireSpawn7.transform.position, BossFireSpawn7.transform.rotation);
			Instantiate (BossFire, BossFireSpawn8.transform.position, BossFireSpawn8.transform.rotation);
			Instantiate (BossFire, BossFireSpawn9.transform.position, BossFireSpawn9.transform.rotation);
			Instantiate (BossFire, BossFireSpawn10.transform.position, BossFireSpawn10.transform.rotation);
			timefr = 0f;
			Shots++;
		}
	}

	void ApplyDamage (float Damage){
		DamageTaken += Damage;
		if (DamageTaken >= life) {
			GC.SendMessage ("Win", SendMessageOptions.RequireReceiver);
			gameObject.SetActive (false);
		}
	}
	void ApplyLittleDamage (float Damage){
		DamageTaken += Damage-9f;
		if (DamageTaken >= life) {
			GC.SendMessage ("Win", SendMessageOptions.RequireReceiver);
			gameObject.SetActive (false);
		}
	}
}
