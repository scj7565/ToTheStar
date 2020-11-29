using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    Text text;
    public bool isPush;
    MoveFadeIn mfi;
    private void Start()
    {
        isPush = false;
        text = GetComponent<Text>();
        mfi = GetComponent<MoveFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isPush = true;
            mfi.enabled = false;
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
