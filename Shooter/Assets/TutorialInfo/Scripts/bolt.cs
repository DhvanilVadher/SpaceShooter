﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolt : MonoBehaviour
{
	public float speed;
	Rigidbody rb;
	void Start()
	{	rb = GetComponent<Rigidbody> ();
		rb.velocity = (transform.forward * speed);
	}
}
