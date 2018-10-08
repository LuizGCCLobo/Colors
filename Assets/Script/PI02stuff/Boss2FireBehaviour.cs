using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2FireBehaviour : MonoBehaviour {

	public float speed;
	public float Damage;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		Destroy (gameObject, 5);
	}
	void OnTriggerEnter2D (Collider2D P){
		if (P.gameObject.tag.Equals ("Player")) {
			P.SendMessage ("ApplyDamage", SendMessageOptions.DontRequireReceiver);
		}
		//if (P.gameObject.tag.Equals ("Lsr")) {
		//	Destroy (gameObject);
		//}
	}
}
