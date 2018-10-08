using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonWidth / 2),
			buttonWidth, buttonHeight),
			"Start")) {
			SceneManager.LoadScene ("Cutscene01");
		}
	}
}