using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour {

	public float timer;

	public int X;
	public int Y;
	//public GameObject B01;
	//public GameObject B02;
	//public GameObject B03;
	//public GameObject B04;
	//public GameObject B05;

	public GameObject smallWall;

	public float timer2;


	// Use this for initialization
	void Start () {
		timer = 0f;
		//B01.SetActive (false);
		//B02.SetActive (false);
		//B03.SetActive (false);
		//B04.SetActive (false);
		//B05.SetActive (false);

		smallWall.gameObject.SetActive (true);
	}

	// Update is called once per frame
	void FixedUpdate () {
		//timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		if (timer2 > Y) {
			smallWall.gameObject.SetActive (false);
		}
		//if (timer >= 5 && !Spawnou) {
		//	X = Random.Range (1, 5);
		//	Spawnou = true;
		//} 
		//if (timer > 13){
		//	timer = 0f;
		//	Spawnou = false;
		//	X = 0;
		//	B01.SetActive (false);
		//	B02.SetActive (false);
			//B03.SetActive (false);
		//	B04.SetActive (false);
		//	B05.SetActive (false);
		//}
		//if (X == 1) {
		//	B01.SetActive (true);
		//}
		//if (X == 2) {
		//	B02.SetActive (true);
		//}
		//if (X == 3) {
			//B03.SetActive (true);
		//}
		//if (X == 3) {
		//	B04.SetActive (true);
		//}
		//if (X == 4) {
		//	B05.SetActive (true);
		//}
	}
}
