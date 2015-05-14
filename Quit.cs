using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quit : MonoBehaviour {
	public VariableList target1;
	public Button endButton;
	
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		endButton = GetComponent<Button> ();
		endButton.onClick.AddListener (loadLevel);
	}
	
	void FixedUpdate () {
		
	}
	
	void loadLevel(){
		Application.Quit();
	}
}