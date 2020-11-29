using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    private EnemyControl ec;
    void Start()
    {
        ec = GetComponent<EnemyControl>();
        ec.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            ec.enabled = true;
        }
    }
}
