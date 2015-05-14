using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {
	public VariableList target1;
	
	void Start () {
		target1 = GameObject.Find ("Main Camera").GetComponent<VariableList>();
		target1.animationTime = Time.time + 5F;
		target1.animationNum = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//return to default position
		if (target1.animationTime < Time.time) {
			target1.animationNum = 0;
		}
		if (target1.animationTimeB < Time.time) {
			target1.animationNumB = 0;
		}
		if (target1.animationTimeR < Time.time) {
			target1.animationNumR = 0;
		}
		if (target1.animationTimeY < Time.time) {
			target1.animationNumY = 0;
		}

		if (gameObject.name.Equals ("greenmonster_0")) {
			//idle animation
			if (target1.animationTime + Random.Range (0F, 3F) < Time.time) {
				if (Random.Range (0F, 2F) < 1) {
					target1.animationNum = 1;
				} else {
					target1.animationNum = 2;
				}
				target1.animationTime = Time.time + 5F;
			}
		}
		if (gameObject.name.Equals ("bluemonster_0")) {
			//idle animation
			if (target1.animationTimeB + Random.Range (0F, 3F) < Time.time) {
				if (Random.Range (0F, 2F) < 1) {
					target1.animationNumB = 1;
				} else {
					target1.animationNumB = 2;
				}
				target1.animationTimeB = Time.time + 5F;
			}
		}
		if (gameObject.name.Equals ("redmonster_0")) {
			//idle animation
			if (target1.animationTimeR + Random.Range (0F, 3F) < Time.time) {
				if (Random.Range (0F, 2F) < 1) {
					target1.animationNumR = 1;
				} else {
					target1.animationNumR = 2;
				}
				target1.animationTimeR = Time.time + 5F;
			}
		}
		if (gameObject.name.Equals ("yellowmonster_0")) {
			//idle animation
			if (target1.animationTimeY + Random.Range (0F, 3F) < Time.time) {
				if (Random.Range (0F, 2F) < 1) {
					target1.animationNumY = 1;
				} else {
					target1.animationNumY = 2;
				}
				target1.animationTimeY = Time.time + 5F;
			}
		}

		//set animationNum
		if (gameObject.name.Equals ("greenmonster_0")) {
			GetComponent<Animator> ().SetInteger ("animationNum", target1.animationNum);
		}
		if (gameObject.name.Equals ("bluemonster_0")) {
			GetComponent<Animator> ().SetInteger ("animationNumB", target1.animationNumB);
		}
		if (gameObject.name.Equals ("redmonster_0")) {
			GetComponent<Animator> ().SetInteger ("animationNumR", target1.animationNumR);
		}
		if (gameObject.name.Equals ("yellowmonster_0")) {
			GetComponent<Animator> ().SetInteger ("animationNumY", target1.animationNumY);
		}
	}
}
