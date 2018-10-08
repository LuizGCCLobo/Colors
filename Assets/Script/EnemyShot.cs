using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

	public GameObject clone;
	public Transform spawnPoint;
	public float fireRate;
	float timer;


	// Use this for initialization
	void Start () {
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
	}
	void FixedUpdate(){
		Batata ();
	}
	void Batata (){
		if (timer > fireRate) {
			Instantiate (clone, spawnPoint.transform.position, transform.rotation);
			timer = 0f;
		}
	}
}
