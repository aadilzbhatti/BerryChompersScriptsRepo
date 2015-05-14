using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour {
	public VariableList target1;
	public Rigidbody2D settings;
	public Button settingsButton;
	public RectTransform settingsLocation;
	public Vector2 velocity;

	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		settings = GameObject.Find ("Canvas Settings").GetComponent<Rigidbody2D>();
		settingsButton = GetComponent<Button>();
		settingsButton.onClick.AddListener (settingsMenu);
		settingsLocation = GameObject.Find ("Canvas Settings").GetComponent<RectTransform>();
		settingsLocation.localPosition = new Vector3(-8,0);
	}
	
	void FixedUpdate () {
		if (settingsLocation.localPosition.x > -3.5 && target1.settingsOpened)
		{
			settings.velocity = new Vector2 (0, 0);
		}
		else if (settingsLocation.localPosition.x < -8 && !target1.settingsOpened)
		{
			settings.velocity = new Vector2 (0, 0);
		}
	}

	void settingsMenu(){
		if (target1.settingsOpened == false) {
			settings.velocity = new Vector2(1,0)*20;
			target1.settingsOpened = true;
		}
		else {
			settings.velocity = new Vector2(-1,0)*20;
			target1.settingsOpened = false;
		}
	}
}
