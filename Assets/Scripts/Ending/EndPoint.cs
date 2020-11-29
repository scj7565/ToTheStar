using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private Rigidbody2D rb;
    float time = 0;
    float fades = 1;
    private SpriteRenderer player;
    bool endingStart;
    public bool isEnd;
    private void Start()
    {
        endingStart = false;
        isEnd = false;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other) //플레이어 리셋
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            endingStart = true;
        }
    }
    private void Update()
    {
        if (endingStart == true)
        {
            time += Time.deltaTime;
            if (fades > 0 && time >= 0.1f)
            {
                fades -= 0.05f;
                player.color = new Color(255, 255, 255, fades);
                time = 0;
            }
            if (player.color.a <= 0)
            {
                isEnd = true;
            }
        }
    }
}
