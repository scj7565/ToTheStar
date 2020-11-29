using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutSprite : MonoBehaviour
{
    public int nextSceneNum;
    float time = 0;
    float fades = 1;
    public SpriteRenderer fade;

    void Update()
    {
        time += Time.deltaTime;
        if (fades > 0 && time >= 0.1f)
        {
            fades -= 0.05f;
            fade.color = new Color(255, 255, 255, fades);
            time = 0;
        }
        if (fade.color.a <= 0)
        {
            SceneManager.LoadScene(nextSceneNum, LoadSceneMode.Single);
        }
    }
}
