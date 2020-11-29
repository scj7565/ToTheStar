using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody2D prb;
    private List<Vector3> newPos;
    public int time;
    private int starttime;
    void OnCollisionEnter2D(Collision2D other)  //플레이어 리셋
    {
        if (other.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void Start()
    {
        prb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        newPos = new List<Vector3>();
        starttime = time;
    }
    void Update()
    {
        newPos.Add(prb.transform.position);
        if (newPos.Count > time * Time.deltaTime)    //플레이어 추격
        {
            transform.position = newPos[0];
            newPos.RemoveAt(0);
        }
        if (starttime != time)
        {
            GetComponent<SpriteRenderer>().color = new Color(70/255f, 70/255f, 70/255f);
        }
    }
}
