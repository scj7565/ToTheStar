using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidCamera : MonoBehaviour
{
	public GameObject player;
	//public Vector2 minPos, maxPos;
	//public bool bound;

	// 캐릭터 초기화
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// 캐릭터의 위에 따라 카메라가 이동하도록 하는 메서드
	void FixedUpdate()
	{
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
	}
}
