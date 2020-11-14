using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLight : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player;
    PlayerTracing pt;
    public float speed;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        pt = GetComponent<PlayerTracing>();
    }
    void Update()
    {
        if (player.activeSelf == false)
        {
            pt.enabled = false;
            Vector2 newPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            rb.velocity = new Vector3(speed * (newPos.x - rb.position.x), speed * (newPos.y - rb.position.y), 0);
        }
        if (player.activeSelf == true)
        {
            pt.enabled = true;
        }
    }
}
