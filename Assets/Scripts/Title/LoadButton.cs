using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadButton : MonoBehaviour
{
    int stage;
    public void Load()
    {
        if (PlayerPrefs.HasKey("Stage"))
        {
            stage = PlayerPrefs.GetInt("Stage");
            SceneManager.LoadScene(stage, LoadSceneMode.Single);
        }
    }
}
