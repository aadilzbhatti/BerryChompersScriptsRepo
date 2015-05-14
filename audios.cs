using UnityEngine;
using System.Collections;

public class audios : MonoBehaviour {
	public AudioClip startscreen;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().clip = startscreen;
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
