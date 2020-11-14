using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class SceneMove : MonoBehaviour
{
    public int nextSceneNum;
    void OnTriggerEnter2D(Collider2D other) //씬 이동
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            this.enabled = false;
            SceneManager.LoadScene(nextSceneNum,LoadSceneMode.Single);
        }
    }
}
