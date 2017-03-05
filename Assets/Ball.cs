using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float speed = 60f;

	// Use this for initialization
	void Start () {
//		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}

	void Update() {
		if (GetComponent<Rigidbody2D> ().velocity.magnitude > speed) {
			GetComponent<Rigidbody2D> ().velocity = GetComponent<Rigidbody2D> ().velocity.normalized * speed;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "RacketLeft") {
			GetComponent<SpriteRenderer> ().color = new Color (0f, 213f, 255f, 1f);
		} else if (coll.gameObject.name == "RacketRight") {
			GetComponent<SpriteRenderer> ().color = new Color (255f, 70f,0f, 1f);
		}

	}

}
