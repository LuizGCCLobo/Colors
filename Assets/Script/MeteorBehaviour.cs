using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour {

	public float speed;
	public float life;
	public float lifeTime;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector2.left * speed * Time.deltaTime);
		Destroy (gameObject, lifeTime);
		if (life <= 0) {
			Destroy (gameObject);
		}
	}
	void Damage (float value){
		life -= value; 
	}
	void OnTriggerEnter2D(Collider2D bolota){
		if (bolota.gameObject.tag.Equals ("Player")) {
			bolota.SendMessage ("ApplyDamage", SendMessageOptions.DontRequireReceiver);
		}
	}
}
