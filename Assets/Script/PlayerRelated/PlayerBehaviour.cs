using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	float directionx;
	float directiony;
	public float speed;

	float timer;
	public float spoilerTimer;
	public float fireRate;

	public GameObject laserP;
	public Transform canonP;

	bool playerMovement;

	GameObject GC;

	AudioSource PlayerAS;
	public AudioClip shotAudio;

	// Use this for initialization
	void Start () {

		timer = 0f;
		spoilerTimer = 0f;
		playerMovement = true;
		GC = GameObject.FindGameObjectWithTag ("GameController");
		PlayerAS = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		spoilerTimer += Time.deltaTime;

		if (playerMovement == true) {
			directionx = Input.GetAxisRaw ("Horizontal");
			directiony = Input.GetAxisRaw ("Vertical");
			transform.Translate (new Vector2 (directionx, directiony) * speed * Time.deltaTime);
		}

		Spoiler ();

		Shoot ();
	}

	void Shoot(){
		if (Input.GetKey(KeyCode.Keypad4) && timer > fireRate) {
			Instantiate (laserP, canonP.transform.position, canonP.transform.rotation);
			timer = 0f;
			PlayerAS.PlayOneShot (shotAudio, 0.02f);
		}
	}

	void PowerUPFireRate(){
		fireRate -= 0.5f;
	}

	void PowerUPSpeedUP(){
		speed++;
	}
	void Spoiler(){
		if (spoilerTimer > 230) {
			playerMovement = false;
		}
	}
	void ApplyDamage(){
		GC.SendMessage ("GameOver");
		gameObject.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D trig){
		if (trig.gameObject.tag.Equals("babydragon")){
			GC.SendMessage ("GameOver");
			gameObject.SetActive (false);
		}
	}
}
