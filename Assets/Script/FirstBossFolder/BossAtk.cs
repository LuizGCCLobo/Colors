using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtk : MonoBehaviour {

	public int lifePoints;
	public GameObject FireBoss;
	public Transform spawnPoint;
	public Transform spawnPointH;
	float timer;
	public float fireRate;
	public GameObject HugeLaser;
	public float fireRateH;
	public float timer2;
	bool normalShot;
	public int countShot;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		timer2 = 0.0f;
		normalShot = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		if (normalShot && countShot < 21) {
			BossFire ();
		}
		if (timer2 >= 16) {
			normalShot = false;
			countShot = 0;
			BossHugeFire ();
		}
		if (timer2 > 17) {
			normalShot = true;
			timer2 = 0.0f;
		}
	}
	void BossFire(){
		if (timer > fireRate) {
			Instantiate (FireBoss, spawnPoint.position, spawnPoint.rotation);
			timer = 0f;
			countShot++;
		}
	}
	void BossHugeFire(){
		if (timer > fireRateH) {
			Instantiate (HugeLaser, spawnPointH.position, spawnPointH.rotation);
			timer = 0f;
		}
	}
	void ApplyDamage(int dmg){
		lifePoints -= dmg;
		if (lifePoints <= 0) {
			Destroy (gameObject);
		}
	}
}
