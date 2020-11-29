using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject title;
    public GameObject begin;
    public GameObject load;
    public GameObject quit;
    public GameObject cam;
    void Start()
    {
        cam.GetComponent<TitleCamera>().enabled = false;
    }
    public void buttonQuit()
    {
        Application.Quit();
    }
    public void buttonBegin()
    {
        title.GetComponent<FadeIn>().enabled = false;
        begin.GetComponent<FadeIn>().enabled = false;
        load.GetComponent<FadeIn>().enabled = false;
        quit.GetComponent<FadeIn>().enabled = false;
        title.GetComponent<FadeOut>().enabled = true;
        begin.GetComponent<FadeOut>().enabled = true;
        load.GetComponent<FadeOut>().enabled = true;
        quit.GetComponent<FadeOut>().enabled = true;
        cam.GetComponent<TitleCamera>().enabled = true;
    }
    public void buttonLoad()
    {

    }
}
