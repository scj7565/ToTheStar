using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Camera : MonoBehaviour
{
	public GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
	}
}