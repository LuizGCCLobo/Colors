﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D T1){
		if (T1.gameObject.tag.Equals ("Shot")) {
			SendMessageUpwards ("ApplyDamage1", true);
			Destroy (T1.gameObject);
		}
	}
}
