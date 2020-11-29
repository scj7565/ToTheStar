using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    Text text;
    public bool isPush;
    ZoomFadeIn zfi;
    private void Start()
    {
        isPush = false;
        text = GetComponent<Text>();
        zfi = GetComponent<ZoomFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
        {
            if (zfi.isEnd == true)
            {
                isPush = true;
                zfi.enabled = false;
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
