using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillText : MonoBehaviour
{
    Text text;
    private Gauge gauge;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        gauge = GameObject.FindGameObjectWithTag("Gauge").GetComponent<Gauge>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gauge.nowSkill.ToString();
    }
}
