using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    public bool invincibleSkill;
    public bool delaySkill;
    public bool stopSkill;
    private InvincibleSkill inv;
    private DelaySkill del;
    private StopSkill stop;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Player").GetComponent<InvincibleSkill>();
        del = GameObject.FindGameObjectWithTag("Player").GetComponent<DelaySkill>();
        stop = GameObject.FindGameObjectWithTag("Player").GetComponent<StopSkill>();
        inv.enabled = false;
        del.enabled = false;
        stop.enabled = false;
    }
    void Update()
    {
        if (invincibleSkill == true)
        {
            inv.enabled = true;
        }
        if (delaySkill == true)
        {
            del.enabled = true;
        }
        if (stopSkill == true)
        {
            stop.enabled = true;
        }

    }
}
