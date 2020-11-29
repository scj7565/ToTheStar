using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleSkill : MonoBehaviour
{
    private GameObject trap;
    private SpriteRenderer player;
    private Rigidbody2D rb;
    private Gauge gauge;
    bool isUsed;
    public bool isSkill;
    bool isMoved;
    // Start is called before the first frame update
    void Start()
    {
        isUsed = false;
        isMoved = false;
        isSkill = false;
        trap = GameObject.FindGameObjectWithTag("Trap");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && gauge.nowSkill >= 10)
        {
            player.color = new Color(255, 255, 255, 100 / 255f);
            trap.SetActive(false);
            isUsed = true;
            isSkill = true;
        }
        if (isUsed == true)
        {
            if (rb.velocity.x >= 0.01 || rb.velocity.x <= -0.01 || rb.velocity.y >= 0.01 || rb.velocity.y <= -0.01)
            {
                isMoved = true;
                isUsed = false;
            }
        }
        if (isMoved == true)
        {
            if (rb.velocity.x <= 0.01 && rb.velocity.x >= -0.01 && rb.velocity.y <= 0.01 && rb.velocity.y >= -0.01)
            {
                player.color = new Color(255, 255, 255, 1);
                trap.SetActive(true);
                isMoved = false;
            }
        }
    }
}
