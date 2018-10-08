using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFireRate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D trig){

		if (trig.gameObject.tag.Equals ("Player")) {
			GameObject P = GameObject.FindGameObjectWithTag ("Player");
			P.SendMessage ("PowerUPFireRate");
			Destroy (gameObject);
		}

	}
}
