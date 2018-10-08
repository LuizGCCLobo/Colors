using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawScript : MonoBehaviour {

	Animator Mouth;

	// Use this for initialization
	void Start () {
		Mouth = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate() {

	}
	void Jaw (float timer){
		Mouth.SetFloat ("Timer", timer);
	}
}
