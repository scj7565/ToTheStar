using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLight : MonoBehaviour
{
    public GameObject skillLight;
    private GameObject playerLight;
    private GameObject player;
    public EnemyControl tracingEnemy;
    Gauge gauge;
    Vector3 pos;
    Quaternion rot;
    void Start()
    {
        playerLight = GameObject.Find("Player Light");
        player = GameObject.FindGameObjectWithTag("Player");
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
    }
    // Update is called once per frame
    void Update()
    {
        if (player.activeSelf == false && Input.GetKeyDown(KeyCode.W) && gauge.nowLight >= 10)
        {
            pos = playerLight.transform.position;
            rot = playerLight.transform.rotation;
            Instantiate(skillLight, pos, rot);
        }
    }
}
