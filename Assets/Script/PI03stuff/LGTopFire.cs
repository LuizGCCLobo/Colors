using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LGTopFire : MonoBehaviour {

	float timer;
	public float FireRate;
	public GameObject RedLaserT;
	public Transform LGTSpawner;

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
			Instantiate (RedLaserT, LGTSpawner.transform.position, LGTSpawner.transform.rotation);
			timer = 0f;
		}
	}
}
