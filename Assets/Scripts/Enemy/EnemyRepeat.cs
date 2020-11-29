using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyRepeat : MonoBehaviour
{
    public GameObject goal;
    private Vector3 startPos;
    private Vector3 goalPos;
    private bool isGoal;
    private Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        isGoal = false;
        startPos = transform.position;
        goalPos = goal.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D other)  //플레이어 리셋
    {
        if (other.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isGoal == false)
        {
            transform.position = Vector3.Lerp(transform.position, goalPos, Time.deltaTime * speed);
            if (rb.velocity.x <= 1 && rb.velocity.y <= 1 && transform.position != startPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, goalPos, Time.deltaTime * speed);
            }
        }
        if (isGoal == true)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime * speed);
            if (rb.velocity.x <= 1 && rb.velocity.y <= 1 && transform.position != goalPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, startPos, Time.deltaTime * speed);
            }
        }
        if (transform.position == goalPos)
        {
            isGoal = true;
        }
        if (transform.position == startPos)
        {
            isGoal = false;
        }
    }
}
