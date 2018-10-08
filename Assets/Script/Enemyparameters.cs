using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyparameters : MonoBehaviour {

    public float life;
    public float lifetime;

	GameObject GC;
	// Use this for initialization
	void Start () {

		GC = GameObject.FindGameObjectWithTag ("GameController");
		
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, lifetime);

        if (life <= 0)
        {
			GC.SendMessage ("PlayEnemyDeath");
            Destroy(gameObject);

        }
		
	}

	void Damage(float value){

		life -= value;

	}

	void OnTriggerEnter2D(Collider2D trig){
		if(trig.gameObject.tag.Equals("Player")){
			trig.gameObject.SendMessage ("ApplyDamage", SendMessageOptions.DontRequireReceiver);
		}
	}
}
