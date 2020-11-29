using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    float currentTime = 0;
    public float startTime = 2;
    Text text;
    TrackFadeIn tfi;
    private void Start()
    {
        text = GetComponent<Text>();
        tfi = GetComponent<TrackFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        currentTime += Time.deltaTime;
        if (tfi.isEnd == true)
        {
            tfi.enabled = false;
            if (fades > 0 && time >= 0.1f && currentTime >= startTime)
            {
                fades -= 0.1f;
                text.color = new Color(255, 255, 255, fades);
                time = 0;
            }
        }
    }
}
