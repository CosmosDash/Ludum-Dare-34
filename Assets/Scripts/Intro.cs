﻿using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	
	public int level = 3;
	public float setTime = 10.0f;
	public float dimTime = 2.0f;
	public Light dimLight; 
	public float zoomSpeed = 0.2f;
	
	Camera c;
	float timer;
	
	// Use this for initialization
	void Start () {
		c = GetComponent<Camera> ();
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		c.fieldOfView -= zoomSpeed;
		if (timer > dimTime && timer < setTime) {
			dimLight.intensity -= zoomSpeed;
		} else if (timer > setTime) {
			Application.LoadLevel (level);
		}
	}
}
