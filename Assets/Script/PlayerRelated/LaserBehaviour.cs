using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour {

	public float speed;
	public float lifeTime;
	public float damage;
	GameObject boss;
	// Use this for initialization
	void Start () {
		boss = GameObject.FindGameObjectWithTag ("Boss");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		Destroy (gameObject, lifeTime);
	}

	void OnTriggerEnter2D (Collider2D trig){

		if(trig.gameObject.tag.Equals("Enemy")){
			trig.gameObject.SendMessage ("Damage", damage, SendMessageOptions.DontRequireReceiver);
			Destroy (gameObject);
		}
		if (trig.gameObject.tag.Equals ("TiroBoss")) {
			trig.gameObject.SendMessage ("Damage", damage, SendMessageOptions.DontRequireReceiver);
		}
		if (trig.gameObject.tag.Equals ("JawM")) {
			boss.gameObject.SendMessage ("ApplyDamage", damage);
			Destroy (gameObject);
		}
		if (trig.gameObject.tag.Equals ("BossB")) {
			boss.gameObject.SendMessage ("ApplyLittleDamage", damage);
			Destroy (gameObject);
		}

	}
}
