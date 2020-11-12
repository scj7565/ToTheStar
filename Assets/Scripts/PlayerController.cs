using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float maxSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.x <= 0.01 && rb.velocity.x >=-0.01 && rb.velocity.y <= 0.01 && rb.velocity.y >= -0.01) //이동
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) //위 방향키
            {
                rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
                if (rb.velocity.y <= maxSpeed)
                {
                    rb.velocity = new Vector2(0, maxSpeed);
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)) //아래 방향키
            {
                rb.AddForce(Vector2.up * -speed, ForceMode2D.Impulse);
                if (rb.velocity.y <= maxSpeed)
                {
                    rb.velocity = new Vector2(0, -maxSpeed);
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow)) //오른쪽 방향키
            {
                rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
                if (rb.velocity.x <= maxSpeed)
                {
                    rb.velocity = new Vector2(maxSpeed, 0);
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)) //왼쪽 방향키
            {
                rb.AddForce(Vector2.right * -speed, ForceMode2D.Impulse);
                if (rb.velocity.x <= maxSpeed)
                {
                    rb.velocity = new Vector2(-maxSpeed, 0);
                }
            }
        }
    }
}
