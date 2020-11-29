using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject poingLight;
    public GameObject globalLight;
    void OnTriggerEnter2D(Collider2D other) //플레이어 리셋
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(poingLight);
            Instantiate(globalLight);
        }
    }
}
