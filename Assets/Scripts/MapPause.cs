using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPause : MonoBehaviour
{
    public bool isPaused;
    private Image img;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        img = GetComponent<Image>();
        img.color = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                img.color = new Color(255, 255, 255, 1);
                Time.timeScale = 0;
                isPaused = true;
                return;
            }
            if (isPaused == true)
            {
                img.color = new Color(255, 255, 255, 0);
                Time.timeScale = 1;
                isPaused = false;
                return;
            }
        }
    }
}
