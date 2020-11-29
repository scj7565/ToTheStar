using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AFadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    Text text;
    public bool isPush;
    AFadeIn afi;
    private void Start()
    {
        isPush = false;
        text = GetComponent<Text>();
        afi = GetComponent<AFadeIn>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.A) && afi.isEnd == true)
        {
            isPush = true;
            afi.enabled = false;
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
