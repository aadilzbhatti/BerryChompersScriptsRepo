using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour {
	public Button levelButton;
	
	void Start () {
		levelButton = GetComponent<Button> ();
		levelButton.onClick.AddListener (loadLevel);
	}
	
	void FixedUpdate () {
		
	}
	
	void loadLevel(){
		Application.LoadLevel("StartLevel");
	}
}