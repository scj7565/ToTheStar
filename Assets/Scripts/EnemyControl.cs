using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody2D prb;
    public GameObject tracing;
    private List<Vector3> newPos;
    public int dist;

    void Awake()
    {
        newPos = new List<Vector3>();
    }
    void OnCollisionEnter2D(Collision2D other)  //플레이어 리셋
    {
        if (other.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void Update()
    {
        prb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        newPos.Add(prb.transform.position);
        if (newPos.Count > dist)    //플레이어 추격
        {
            transform.position = newPos[0];
            newPos.RemoveAt(0);
        }
    }
}
