using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManage : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isPaused;
    private GameObject player;
    public EnemyControl tracingEnemy;
    void Start()
    {
        isPaused = false;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (rb.velocity.x <= 0.01 && rb.velocity.x >= -0.01 && rb.velocity.y <= 0.01 && rb.velocity.y >= -0.01)
            {
                if (isPaused == false)
                {
                    isPaused = true;
                    player.gameObject.SetActive(false);
                    if (tracingEnemy != null) tracingEnemy.enabled = false;
                    return;
                }
                if (isPaused == true)
                {
                    isPaused = false;
                    player.gameObject.SetActive(true);
                    if (tracingEnemy != null) tracingEnemy.enabled = true;
                    return;
                }
            }
            else Debug.Log("스킬은 정지상태에서만 사용할 수 있습니다");
        }
    }
}
