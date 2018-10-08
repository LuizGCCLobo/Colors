using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotBehaviour : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
		Destroy (gameObject, 2);
	}
	void OnTriggerEnter2D(Collider2D ota){
		if (ota.gameObject.tag.Equals ("Player")) {
			GameObject GC = GameObject.FindGameObjectWithTag ("GameController");
			GC.SendMessage ("GameOver");
			Destroy (ota.gameObject);
		}
	}
}
