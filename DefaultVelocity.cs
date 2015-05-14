using UnityEngine;
using System.Collections;

public class DefaultVelocity : MonoBehaviour {
	public Vector2 velocity;
	public VariableList target1;
	public float xDirection;
	public float yDirection;
	public float hypotenuse;

	void Start () {
		//calculate direction of fruit
		hypotenuse = Mathf.Sqrt((Mathf.Pow (transform.position.x, 2) + Mathf.Pow (transform.position.y, 2)));
		xDirection = transform.position.x / hypotenuse * -1;
		yDirection = transform.position.y / hypotenuse * -1;
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
	}
	
	void FixedUpdate () {
		//update velocity of fruit
		transform.Rotate (Vector3.forward * 5);
		if (target1.animationState) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0); //fruit stops during transition animations/pause
		}
		else if (target1.gameOver == false) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (xDirection, yDirection) * target1.speed;
		} else if (target1.gameOver) {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
		}
	}
}
