﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;
	public Vector3 offset = Vector3.zero;

	void Start()
	{
		offset = transform.position - player.transform.position;
	}
	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}
