using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySkill : MonoBehaviour
{
    EnemyControl ec;
    Gauge gauge;
    public bool isUsed;
    // Start is called before the first frame update
    void Start()
    {
        isUsed = false;
        ec = GameObject.FindGameObjectWithTag("TracingEnemy").GetComponent<EnemyControl>();
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && isUsed == false)
        {
            ec.time += 30000;
            isUsed = true;
        }
    }
}
