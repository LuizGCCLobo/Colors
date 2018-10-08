using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMasterMaster : MonoBehaviour {

	public Transform target;
	public float speed;
	int X;
	int Y=0;
	bool isMoving;

	// Use this for initialization
	void Start () {

		isMoving = false;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (isMoving) {
			X = 0;
			transform.position = new Vector3 (X, target.position.y * speed * Time.deltaTime);
		}

	}

	void MoveBossToPlayer(bool MBTP){
		if (MBTP) {
			isMoving = true;
		}
	}

	void DontMoveToPlayer(bool DMTP){
		if (DMTP) {
			isMoving = false;
		}
	}
	void ResetPos(){
		transform.position = new Vector2 (X, Y);
	}

}
