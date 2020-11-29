using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMOff : MonoBehaviour
{
    void Awake()
    {
        var obj = FindObjectsOfType<BGM>();
        if (obj.Length == 1)
        {
            Destroy(gameObject);
        }
    }
}
