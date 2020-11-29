using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    float time = 0;
    float currentTime = 0;
    float fades = 0;
    public float startTime;
    public UnityEngine.UI.Image fade;
    FadeOut fo;
    public FadeOutSprite fos;

    void Start()
    {
        fade.color = new Color(255, 255, 255, 0);
        fo = GetComponent<FadeOut>();
        fo.enabled = false;
        fos.enabled = false;
    }

    void Update()
    {
        time += Time.deltaTime;
        currentTime += Time.deltaTime;
        if (fades <= 255 && time >= 0.1f && currentTime >= startTime)
        {
            fades += 0.1f;
            fade.color = new Color(255, 255, 255, fades);
            time = 0;
        }
    }
}
