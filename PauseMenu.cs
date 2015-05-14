using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
	public VariableList target1;
	public Canvas pauseMenu;

	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		pauseMenu = GetComponent<Canvas> ();
		pauseMenu.enabled=false; //pause screen canvas starts out disabled
	}

	//enables and disables the pause screen
	void FixedUpdate () {
		if (target1.animationState) {
			pauseMenu.enabled=true;
		}
		else {
			pauseMenu.enabled=false;
		}
	}
}
