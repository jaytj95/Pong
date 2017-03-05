using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {
	public float speed = 30;
	public string vAxis = "Vertical";
	public string hAxis = "Horizontal";

	void FixedUpdate () {
		float v = Input.GetAxisRaw (vAxis);
		float h = Input.GetAxisRaw (hAxis);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (h, v) * speed;
	}
}
