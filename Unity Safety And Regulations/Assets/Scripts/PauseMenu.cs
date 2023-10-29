using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Meter;
    public bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Meter.SetActive(false);
        Time.timeScale = 0f;
        ispaused = true;
    }
    
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Meter.SetActive(true);
        Time.timeScale = 1f;
        ispaused = false;
    }

}
