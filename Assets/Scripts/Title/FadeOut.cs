using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    float time = 0;
    float fades = 1;
    public UnityEngine.UI.Image fade;

    void Update()
    {
        time += Time.deltaTime;
        if (fades > 0 && time >= 0.1f)
        {
            fades -= 0.1f;
            fade.color = new Color(255, 255, 255, fades);
            time = 0;
        }
    }
}
