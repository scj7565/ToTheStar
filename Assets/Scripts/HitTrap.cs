using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HitTrap : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) //플레이어 리셋
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
