using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;

    Vector3 StartPos;
    Quaternion StartRot;

    void Awake()
    {
        StartPos = GameObject.FindGameObjectWithTag("Start").transform.position;
        StartRot = GameObject.FindGameObjectWithTag("Start").transform.rotation;
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, StartPos, StartRot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
