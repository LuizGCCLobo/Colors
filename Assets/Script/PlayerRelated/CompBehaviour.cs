using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompBehaviour : MonoBehaviour {

	public Transform playerShip;
	public float speed;

	float timer;
	public float fireRate;

	public GameObject laserC;
	public Transform canonC;

	// Use this for initialization
	void Start () {

		timer = 0f;

		playerShip = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		FollowPlayer ();

		SHoot ();
		
	}

	void FollowPlayer(){
		transform.position = new Vector2 (playerShip.position.x - 1.3f, playerShip.position.y * speed);
	}

	void SHoot(){
		if (Input.GetKey(KeyCode.Keypad5) && timer > fireRate) {
			Instantiate (laserC, canonC.transform.position, canonC.transform.rotation);
			timer = 0f;
		}
	}
}
