using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneGenericBehaviour2 : MonoBehaviour {

	public Text placeHolder1;
	public Text placeHolder2;
	public Text placeHolder3;
	public Text placeHolder4;
	public Text placeHolder5;

	public GameObject Cena01;
	public GameObject Cena02;
	public GameObject Cena03;
	public GameObject Cena04;
	public GameObject Cena05;

	public int cutsceneController;

	// Use this for initialization
	void Start () {

		cutsceneController = 0;

		placeHolder1.gameObject.SetActive (false);
		placeHolder2.gameObject.SetActive (false);
		placeHolder3.gameObject.SetActive (false);
		placeHolder4.gameObject.SetActive (false);
		placeHolder5.gameObject.SetActive (false);

		Cena01.gameObject.SetActive (true);
		Cena02.gameObject.SetActive (false);
		Cena03.gameObject.SetActive (false);
		Cena04.gameObject.SetActive (false);
		Cena05.gameObject.SetActive (false);

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
			placeHolder2.gameObject.SetActive (false);
			Cena02.gameObject.SetActive (false);
			placeHolder3.gameObject.SetActive (true);
			Cena03.gameObject.SetActive (true);
		} else if (cutsceneController == 4) {
			Cena03.gameObject.SetActive (false);
			placeHolder3.gameObject.SetActive (false);
			Cena04.gameObject.SetActive (true);
			placeHolder4.gameObject.SetActive (true);
		} else if (cutsceneController == 5) {
			Cena04.gameObject.SetActive (false);
			placeHolder4.gameObject.SetActive (false);
			Cena05.gameObject.SetActive (true);
			placeHolder5.gameObject.SetActive (true);
		} else if (cutsceneController == 6) {
			SceneManager.LoadScene ("Main2");
		}
	}
}