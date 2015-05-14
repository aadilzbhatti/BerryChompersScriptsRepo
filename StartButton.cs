using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {
	public VariableList target1;
	public Button levelButton;
	
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		levelButton = GetComponent<Button> ();
		levelButton.onClick.AddListener (loadLevel);
	}
	
	void FixedUpdate () {
		
	}

	void loadLevel(){
		Application.LoadLevel("DinoLevel");
		target1.lives = 3;
		target1.counter = 0;
		target1.animationState = false;
		target1.animationNum = 0;
		target1.gameOver = false;
		target1.speed = 2f;
	}
}