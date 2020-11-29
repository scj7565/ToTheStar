using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill0 : MonoBehaviour
{
    private InvincibleSkill inv;
    private DelaySkill del;
    private StopSkill stop;
    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Player").GetComponent<InvincibleSkill>();
        del = GameObject.FindGameObjectWithTag("Player").GetComponent<DelaySkill>();
        stop = GameObject.FindGameObjectWithTag("Player").GetComponent<StopSkill>();
        inv.enabled = false;
        del.enabled = false;
        stop.enabled = false;
    }
}
