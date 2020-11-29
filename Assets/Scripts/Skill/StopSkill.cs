using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSkill : MonoBehaviour
{
    private Vector2 saveSpeed;
    private Rigidbody2D rb;
    private Gauge gauge;
    private bool isUsed;
    // Start is called before the first frame update
    void Start()
    {
        isUsed = false;
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (isUsed == false && gauge.nowSkill >= 20)
            {
                saveSpeed = rb.velocity;
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                gauge.nowSkill -= 20;
                isUsed = true;
            }
            else if (isUsed == true)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                rb.velocity = saveSpeed;
                isUsed = false;
            }
        }
    }
}
