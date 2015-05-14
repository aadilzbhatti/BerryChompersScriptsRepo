using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public VariableList target1;

	// Use this for initialization
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
	}
	
	// Update is called once per frame
	void Update () {
		//controls
		if (target1.gameOver == false && target1.animationState == false) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Rotate (Vector3.forward * 7);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Rotate (Vector3.forward * -7);
			}
		}
	}
}
