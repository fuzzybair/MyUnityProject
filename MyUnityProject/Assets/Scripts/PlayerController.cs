﻿using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{

	// Use this for initialization
	void Start()
	{
	}
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		if (!isLocalPlayer) return;

		float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}
