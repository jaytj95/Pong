using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls2 : MonoBehaviour {
	public GameObject paddle1;
	public float paddleRotationSpeed = 30;
	private float paddle1Rotation = 0;
	private float paddle2Rotation = 0;


	/*
	 * PLAYER 1 CONTROL
	 */
	KeyCode P1_LEFT_ROTATE = KeyCode.Comma;
	KeyCode P1_RIGHT_ROTATE = KeyCode.Period;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		player1 ();
	}


	private void player1() {
		if (Input.GetKey (P1_LEFT_ROTATE) && !Input.GetKey (P1_RIGHT_ROTATE)) {
			paddle1Rotation += paddleRotationSpeed;
			if (paddle1Rotation == 360)
				paddle1Rotation = 0;

		} else if (!Input.GetKey (P1_LEFT_ROTATE) && Input.GetKey (P1_RIGHT_ROTATE)) {
			paddle1Rotation -= paddleRotationSpeed;
			if (paddle1Rotation == 360)
				paddle1Rotation = 0;
		}
		else if(Input.GetKey (P1_LEFT_ROTATE) && Input.GetKey (P1_RIGHT_ROTATE)) {
			paddle1Rotation -= paddleRotationSpeed*2;
			if (paddle1Rotation < 0) {
				paddle1Rotation = 0;
			}
		}
		//paddle 1 rotation
		paddle1.GetComponent<Rigidbody2D> ().transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (0, 0, paddle1Rotation), Time.deltaTime * 30);
	}

	//	private void player2() {
	//		if (Input.GetKey (P2_LEFT_ROTATE) && !Input.GetKey (P2_RIGHT_ROTATE)) {
	//			paddle2Rotation += paddleRotationSpeed;
	//			if (paddle2Rotation == 360)
	//				paddle2Rotation = 0;
	//
	//		} else if (!Input.GetKey (P2_LEFT_ROTATE) && Input.GetKey (P2_RIGHT_ROTATE)) {
	//			paddle2Rotation -= paddleRotationSpeed;
	//			if (paddle2Rotation == 360)
	//				paddle2Rotation = 0;
	//		}
	//		else if(Input.GetKey (P2_LEFT_ROTATE) && Input.GetKey (P2_RIGHT_ROTATE)) {
	//			paddle2Rotation -= paddleRotationSpeed*2;
	//			if (paddle2Rotation < 0) {
	//				paddle2Rotation = 0;
	//			}
	//		}
	//		//paddle 2 rotation
	//		paddle2.GetComponent<Rigidbody2D> ().transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (0, 0, paddle2Rotation), Time.deltaTime * 30);
	//	}
}
