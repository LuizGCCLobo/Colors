using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimScript : MonoBehaviour {

	Animator Anim;
	float timer;

	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Anim.SetFloat ("Transition", timer);
		if (timer >= 4) {
			SendMessageUpwards ("BoolMBTP", true);
		}
	}
	void Again(bool Again){
		if (Again) {
			Anim.Play ("MoveBoss1", -1, 0f);
			Again = false;
		}
	}
}
