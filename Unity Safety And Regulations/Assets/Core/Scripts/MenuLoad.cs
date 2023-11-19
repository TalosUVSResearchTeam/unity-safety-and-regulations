using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoad : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Main Menu Scene");
        Time.timeScale=1;
        PlayerPrefs.SetInt("index", 0);
    }
}
