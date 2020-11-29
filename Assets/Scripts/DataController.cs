using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour
{
    public int nowStageNum;
    public int highStageNum;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Stage"))
        {
            highStageNum = PlayerPrefs.GetInt("Stage");
        }
        else
        {
            highStageNum = 0;
        }
        nowStageNum = SceneManager.GetActiveScene().buildIndex;
        if (highStageNum <= nowStageNum)
        {
            PlayerPrefs.SetInt("Stage", nowStageNum);
            PlayerPrefs.Save();
        }
    }
}
