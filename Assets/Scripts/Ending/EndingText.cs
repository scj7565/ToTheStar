using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingText : MonoBehaviour
{
    float time = 0;
    float fades = 0;
    Text text;
    public EndingCam ec;
    void Start()
    {
        text = GetComponent<Text>();
        text.color = new Color(255, 255, 255, 0);
    }

    void Update()
    {
        time += Time.deltaTime;
        if (fades <= 1 && time >= 0.1f && ec.isEnd == true)
        {
            fades += 0.1f;
            text.color = new Color(255, 255, 255, fades);
            time = 0;
        }
    }
}
