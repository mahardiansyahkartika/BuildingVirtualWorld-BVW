﻿using UnityEngine;
using System.Collections;

public class Bouyancy : MonoBehaviour 
{
	public float Buoyancy=1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if(other.gameObject.tag == "Water")
		{
			Vector2 Up = new Vector2(0,1);
			rigidbody2D.AddForce(Up*Buoyancy);
		}
	}
}