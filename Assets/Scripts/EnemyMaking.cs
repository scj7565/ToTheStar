using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaking : MonoBehaviour
{
    public GameObject Enemy;
    public float time;

    Vector3 StartPos;
    Quaternion StartRot;

    void Awake()
    {
        StartPos = GameObject.FindGameObjectWithTag("Start").transform.position;
        StartRot = GameObject.FindGameObjectWithTag("Start").transform.rotation;
    }
    void Making()
    {
        Instantiate(Enemy, StartPos, StartRot);
    }

    void Start()
    {
        Invoke("Making", time);
    }

    void Update()
    {
        
    }
}
