using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {

	public Transform target;
	public float speed;
	public float timer;
	float Phase;
	int x;
	Animator anime;

	// Use this for initialization
	void Start () {
		Phase = 0.0f;
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		anime = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Phase += Time.deltaTime;
		anime.SetFloat ("timer", Phase);

		if (Phase >= 12 && Phase <= 15) {
			SendMessageUpwards ("MoveBossToPlayer", true);
		} else {
			SendMessageUpwards ("DontMoveToPlayer", true);
		}
		if (Phase > 17) {
			Phase = 0.0f;
			SendMessageUpwards ("ResetPos");
		}
	}
	void MoveBossToPlayer(){
		x = 4;
		transform.position = new Vector3 (x, target.position.y * speed * Time.deltaTime);
	}
	//void MoveBoss(){
	//	x = 4;
	//	transform.position = new Vector2 (x, y);
	//	if (MaisY) {
	//		y++;
	//	}
	//	if (y == 4) {
	//		MaisY = false;
	//	}
	//	if (!MaisY) {
	//		y--;
	//	}
	//	if (y == -3 && !MaisY){
	//		MaisY = true;
	//	}
	//}
}
