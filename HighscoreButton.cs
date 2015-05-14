using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreButton : MonoBehaviour {
	public Button highscoreButton;
	
	void Start () {
		highscoreButton = GetComponent<Button> ();
		highscoreButton.onClick.AddListener (loadLevel);

	}
	
	void FixedUpdate () {
		
	}
	
	void loadLevel(){
		Application.LoadLevel("Highscore");
	}
}