﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				float xFactor = Random.Range (-5, 5);
				this.rigidbody2D.velocity = new Vector2 (xFactor, 10f);
				print (xFactor);
			}
		}
	}
}
