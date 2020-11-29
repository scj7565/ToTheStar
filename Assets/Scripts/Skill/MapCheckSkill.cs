using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapCheckSkill : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isPaused;
    private GameObject player;
    public EnemyControl tracingEnemy;
    private Gauge gauge;
    private bool isStarted;
    public TilemapRenderer tilemapRenderer;
    void Start()
    {
        isPaused = false;
        isStarted = false;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
        if (tilemapRenderer != null) tilemapRenderer.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x >= 0.01 || rb.velocity.x <= -0.01 || rb.velocity.y >= 0.01 || rb.velocity.y <= -0.01)
        {
            isStarted = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (rb.velocity.x <= 0.01 && rb.velocity.x >= -0.01 && rb.velocity.y <= 0.01 && rb.velocity.y >= -0.01)
            {
                if (isPaused == false && gauge.nowLight >= 5)
                {
                    isPaused = true;
                    player.gameObject.SetActive(false);
                    if (tracingEnemy != null && isStarted == true) tracingEnemy.enabled = false;
                    if (tilemapRenderer != null) tilemapRenderer.enabled = true;
                    return;
                }
                if (isPaused == true)
                {
                    isPaused = false;
                    player.gameObject.SetActive(true);
                    if (tracingEnemy != null && isStarted == true) tracingEnemy.enabled = true;
                    if (tilemapRenderer != null) tilemapRenderer.enabled = false;
                    return;
                }
            }
        }
    }
}
