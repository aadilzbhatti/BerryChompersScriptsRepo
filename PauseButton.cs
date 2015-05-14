using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {
	public VariableList target1;
	public Button pause;
	
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		pause = GetComponent<Button> ();
		pause.onClick.AddListener (pauseGame);
	}
	
	void FixedUpdate () {
		
	}	
	
	void pauseGame(){
		if (target1.animationState) {
			target1.animationState = false;
		} else {
			target1.animationState = true;
		}
	}
}
