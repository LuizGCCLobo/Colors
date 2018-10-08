using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LGBotFire : MonoBehaviour {

	float timer;
	public float FireRate;
	public GameObject RedLaserB;
	public Transform LGBSpawner;

	// Use this for initialization
	void Start () {
		timer = 0f;
		Destroy (gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Fire ();
	}
	void Fire(){
		if (timer > FireRate) {
			Instantiate (RedLaserB, LGBSpawner.transform.position, LGBSpawner.transform.rotation);
			timer = 0f;
		}
	}
}
