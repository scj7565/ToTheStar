using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    Text text;
    public bool isPush;
    RFadeIn rfi;
    private void Start()
    {
        isPush = false;
        text = GetComponent<Text>();
        rfi = GetComponent<RFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (rfi.isEnd == true)
            {
                isPush = true;
                rfi.enabled = false;
            }
        }
        if (isPush == true)
        {
            if (fades > 0 && time >= 0.1f)
            {
                fades -= 0.1f;
                text.color = new Color(255, 255, 255, fades);
                time = 0;
            }
        }
    }
}
