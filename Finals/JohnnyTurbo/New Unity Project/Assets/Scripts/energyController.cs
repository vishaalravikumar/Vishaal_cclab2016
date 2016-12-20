﻿using UnityEngine;
using System.Collections;

public class energyController : MonoBehaviour {

	public float sporeSpeedHigh;
	public float sporeSpeedLow;
	public float sporeAngle;
	public float sporeTorqueAngle;

	Rigidbody2D sporeRB;

	// Use this for initialization
	void Start () {
		sporeRB = GetComponent<Rigidbody2D> ();
		sporeRB.AddForce (new Vector2 (Random.Range (-sporeAngle, sporeAngle), Random.Range (sporeSpeedLow, sporeSpeedHigh)), ForceMode2D.Impulse);
		sporeRB.AddTorque ((Random.Range (-sporeTorqueAngle, sporeTorqueAngle)));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
