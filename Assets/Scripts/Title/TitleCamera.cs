using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamera : MonoBehaviour
{
    public GameObject targetCam;
    public UnityEngine.UI.Image button;
    public float speed;
    public FadeOutSprite fo;
    void FixedUpdate()
    {
        if (button.color.a <= 0)
        {
            transform.position = Vector3.Lerp(transform.position, targetCam.transform.position, speed * Time.deltaTime);
            fo.enabled = true;
        }
    }
}
