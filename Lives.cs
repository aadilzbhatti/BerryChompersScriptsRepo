using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {
	public VariableList target1;
	public Text livesGui;
	
	// Use this for initialization
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		livesGui = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		livesGui.text = "Lives: " + target1.lives.ToString ();
		if (target1.lives == 0) {
			Application.LoadLevel("EndLevel");
		}
		
	}
}
