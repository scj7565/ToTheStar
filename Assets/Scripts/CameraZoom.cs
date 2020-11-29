using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    Camera cam;
    public float speed = 0.5f;
    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && cam.orthographicSize >= 1.5f)
        {
            cam.orthographicSize = cam.orthographicSize - speed;
        }
        if (Input.GetKeyDown(KeyCode.X) && cam.orthographicSize <= 10f)
        {
            cam.orthographicSize = cam.orthographicSize + speed;
        }
    }
}
