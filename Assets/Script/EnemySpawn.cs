using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {


    public GameObject Enemy1;
    float timer;
    public float spawntime;
    
    void Start () {
        timer = 0f;
	}
	
	void Update () {
        timer += Time.deltaTime;

		if (timer > spawntime)
        {

			Instantiate(Enemy1,transform.position, transform.rotation);
			timer = 0f;
        }
	}
}
