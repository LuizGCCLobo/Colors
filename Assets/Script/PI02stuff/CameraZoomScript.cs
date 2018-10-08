using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomScript : MonoBehaviour {

	public float timer;

	public float whenZoom;
	public float zoomOut = 5;

	bool isTrue;

	// Use this for initialization
	void Start () {

		timer = 0;
		isTrue = true;

	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer > whenZoom && isTrue == true) {
			zoomOut += 0.0625f;
		}

		if (zoomOut >= 8) {
			isTrue = false;
		}
			
		GetComponent<Camera> ().orthographicSize = zoomOut;
		
	}
}
