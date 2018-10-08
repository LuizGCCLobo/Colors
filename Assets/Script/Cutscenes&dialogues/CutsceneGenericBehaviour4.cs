using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneGenericBehaviour4 : MonoBehaviour {

	public Text placeHolder1;
	public Text placeHolder2;


	public GameObject Cena01;
	public GameObject Cena02;


	public int cutsceneController;

	// Use this for initialization
	void Start () {

		cutsceneController = 0;

		placeHolder1.gameObject.SetActive (false);
		placeHolder2.gameObject.SetActive (false);


		Cena01.gameObject.SetActive (true);
		Cena02.gameObject.SetActive (false);


	}

	// Update is called once per frame
	void Update () {

		CutsceneFrames ();

	}

	void CutsceneFrames(){

		if (Input.GetKeyDown (KeyCode.KeypadEnter) || Input.GetKeyDown (KeyCode.Space)) {
			cutsceneController++;
		}
		if (cutsceneController == 1) {
			placeHolder1.gameObject.SetActive (true);
		} else if (cutsceneController == 2) {
			placeHolder1.gameObject.SetActive (false);
			Cena01.gameObject.SetActive (false);
			placeHolder2.gameObject.SetActive (true);
			Cena02.gameObject.SetActive (true);
		} else if (cutsceneController == 3) {
			SceneManager.LoadScene ("Menu");
		}
	}
}