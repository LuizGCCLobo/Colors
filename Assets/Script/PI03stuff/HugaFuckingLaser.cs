using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HugaFuckingLaser : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * speed * Time.deltaTime);
		Destroy (gameObject, 5);
	}
	void OnTriggerEnter2D(Collider2D Red){
		if (Red.gameObject.tag.Equals ("Player")) {
			Destroy (gameObject);
		}
	}
}
