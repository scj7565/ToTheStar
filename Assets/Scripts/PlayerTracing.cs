using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracing : MonoBehaviour
{
	public GameObject playerCam;

	void Start()
	{
	}

	void FixedUpdate()
	{
		playerCam = GameObject.FindGameObjectWithTag("Player");
		transform.position = new Vector3(playerCam.transform.position.x, playerCam.transform.position.y, transform.position.z);
	}
}
