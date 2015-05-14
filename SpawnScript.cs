using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public Vector3 velocity;
	public Rigidbody2D redPrefab;
	public Rigidbody2D bluePrefab;
	public Rigidbody2D greenPrefab;
	public Rigidbody2D yellowPrefab;
	public Transform ball;
	public float spawnTime = 1F;
	public float delay = 2F;
	public float angle;
	public VariableList target1;
	
	void Start()
	{
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		if (Time.time > spawnTime) {
			spawnTime = Time.time + delay; //update spawnTime at the start of the game
		}
	}
	
	void FixedUpdate () {
		if (target1.animationState == false) {
			//Spawn point appears randomly on a circle offscreen (so no balls reach the center at the same time)
			angle = Random.Range (0F, 360.0F);
			GetComponent<Rigidbody2D>().position = new Vector3 (9F * Mathf.Cos (angle), 9F * Mathf.Sin (angle), 0);
			
			//Delay time between spawning balls should decrease. Time.time = current time - time at the beginning of the game
			if (Time.time > spawnTime) {
				if (target1.gameOver == false) {
					Spawn ();
				}
				spawnTime = Time.time + delay;
			}
			delay *= .9997F;
		}
		else {
			if (Time.time > spawnTime) {
				spawnTime = Time.time + delay; //update spawnTime while paused
			}
		}

	}
	public void Spawn()
	{
		//Spawn code
		if (Random.Range (0F, 4F) <= 1) {
			Instantiate (redPrefab, ball.position, Quaternion.identity);
		} else if (Random.Range (0F, 4F) <= 2) {
			Instantiate (bluePrefab, ball.position, Quaternion.identity);
		} else if (Random.Range (0F, 4F) <= 3) {
			Instantiate (greenPrefab, ball.position, Quaternion.identity);
		} else {
			Instantiate (yellowPrefab, ball.position, Quaternion.identity);
		}
	}
}