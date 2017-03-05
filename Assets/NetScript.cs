using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetScript : MonoBehaviour {
	public GameObject wall;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics2D.IgnoreCollision (wall.GetComponent<Collider2D> (), ball.GetComponent<Collider2D>());
	}
}
