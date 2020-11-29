using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public float nowLight;
    public float nowSkill;
    public Image nowLightBar;
    public Image nowSkillBar;
    private float speed = 10;
    private GameObject player;
    private GameObject trap;
    private bool sUsed;
    // Start is called before the first frame update
    void Start()
    {
        sUsed = false;
        player = GameObject.FindGameObjectWithTag("Player");
        trap = GameObject.FindGameObjectWithTag("Trap");
        nowLight = 100;
        nowSkill = 100;
    }
    // Update is called once per frame
    void Update()
    {
        if (nowLight / 100 != nowLightBar.fillAmount)
        {
            nowLightBar.fillAmount = Mathf.Lerp(nowLightBar.fillAmount, nowLight / 100, Time.deltaTime * speed);
        }
        if (nowSkill / 100 != nowSkillBar.fillAmount)
        {
            nowSkillBar.fillAmount = Mathf.Lerp(nowSkillBar.fillAmount, nowSkill / 100, Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Q) && player.activeSelf == true)
        {
            nowLight -= 5;
        }
        if (Input.GetKeyDown(KeyCode.W) && player.activeSelf == false && nowLight >= 10)
        {
            nowLight -= 10;
        }
        if (player.GetComponent<InvincibleSkill>().isSkill==true)
        {
            nowSkill -= 10;
            player.GetComponent<InvincibleSkill>().isSkill = false;
        }
        if (player.GetComponent<DelaySkill>().isUsed == true && sUsed == false)
        {
            nowSkill -= 50;
            sUsed = true;
        }
        if (nowLight < 0)
        {
            nowLight = 0;
        }
        if (nowSkill < 0)
        {
            nowSkill = 0;
        }
    }
}
