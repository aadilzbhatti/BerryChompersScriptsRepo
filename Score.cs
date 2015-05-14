using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public VariableList target1;
	public Text scoreGui;
	
	// Use this for initialization
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		scoreGui = GetComponent<Text> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		scoreGui.text = "Score: " + target1.counter.ToString ();
		
	}
}
