using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ZoomFadeIn : MonoBehaviour
{
    float time = 0;
    float fades = 0;
    Text text;
    public bool isEnd;
    public Text preText;
    public WFadeOut wfo;

    void Start()
    {
        isEnd = false;
        text = GetComponent<Text>();
        text.color = new Color(255, 255, 255, 0);
    }

    void Update()
    {
        time += Time.deltaTime;
        if (fades <= 1 && time >= 0.1f && preText.color.a <= 0 && wfo.isPush == true)
        {
            fades += 0.1f;
            text.color = new Color(255, 255, 255, fades);
            time = 0;
        }
        if (fades >= 1)
        {
            isEnd = true;
        }
    }
}
