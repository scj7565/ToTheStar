using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    Text text;
    public bool isPush;
    WFadeIn wfi;
    private void Start()
    {
        isPush = false;
        text = GetComponent<Text>();
        wfi = GetComponent<WFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W))
        {
            if (wfi.isEnd == true)
            {
                isPush = true;
                wfi.enabled = false;
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
