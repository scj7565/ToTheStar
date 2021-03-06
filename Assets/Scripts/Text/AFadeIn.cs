﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AFadeIn : MonoBehaviour
{
    float time = 0;
    float fades = 0;
    Text text;
    public bool isEnd;

    void Start()
    {
        text = GetComponent<Text>();
        text.color = new Color(255, 255, 255, 0);
        isEnd = false;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (fades <= 1 && time >= 0.1f)
        {
            fades += 0.1f;
            text.color = new Color(255, 255, 255, fades);
            time = 0;
            isEnd = true;
        }
    }
}
