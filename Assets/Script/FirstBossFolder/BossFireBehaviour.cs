using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFireBehaviour : MonoBehaviour {

	public float speed;
	public float damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		Destroy (gameObject, 2f);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag.Equals("Player")){
			other.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
		}
	}
}
