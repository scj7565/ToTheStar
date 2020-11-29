using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCam : MonoBehaviour
{
    public EndPoint ep;
    private Camera cam;
    public float speed;
    public bool isEnd;
    // Start is called before the first frame update
    void Start()
    {
        isEnd = false;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ep.isEnd == true)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 5.79f, speed * Time.deltaTime);
        }
        if (cam.orthographicSize >= 5.5f)
        {
            isEnd = true;
        }
    }
}
