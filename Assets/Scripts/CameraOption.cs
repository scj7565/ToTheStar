using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOption : MonoBehaviour
{
    GameObject player;
    PlayerTracing pt;
    Tracing t;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pt = GetComponent<PlayerTracing>();
        t = GetComponent<Tracing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.activeSelf == false)
        {
            pt.enabled = false;
            t.enabled = true;
        }
        if (player.activeSelf == true)
        {
            pt.enabled = true;
            t.enabled = false;
        }
    }
}
