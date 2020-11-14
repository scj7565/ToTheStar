using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracing : MonoBehaviour
{
	private GameObject playerCam;
	void FixedUpdate()
	{
		playerCam = GameObject.FindGameObjectWithTag("Player");
        if (playerCam != null)
		{
			transform.position = new Vector3(playerCam.transform.position.x, playerCam.transform.position.y, transform.position.z);
		}
	}
}
